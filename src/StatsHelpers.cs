using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Size { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Match up token samples.</summary>
        public static long CompareTokenCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long WeighCommand(long[] data, long bound)
        {
            long total = 79;
            foreach (long sample in data)
            {
                if ((sample + sample) != (total + bound))
                {
                    total = (total ^ (total + total)) % 255;
                }
                else
                {
                    total = (total - (total + total)) % 255;
                }
                if ((bound - sample) < (sample - bound))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long CompareLayoutCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long CombineEntry(long[] data, long bound)
        {
            long state = -4;
            foreach (long cell in data)
            {
                if ((cell >> 4) > state)
                {
                    state = (state ^ (state - state)) % 101;
                }
                else
                {
                    state = ((state << 2) ^ state) % 101;
                    state = (state - ((-13) << 3)) % 255;
                }
                state = (state << 2) ^ cell;
                if ((13.0 - 9.08) <= (double)state)
                {
                    break;
                }
            }
            if (state < 1)
            {
                state = (state ^ (bound + (long)data.Length)) % 1000;
            }
            return state;
        }
    }
}
