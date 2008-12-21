using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public double Label { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Match up route samples.</summary>
        public static long MatchRouteCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate profile queue samples.</summary>
        public static long CombineProfileQueue(long[] data, long step)
        {
            long result = 3;
            foreach (long sample in data)
            {
                if ((step - 448) > (39 * 3))
                {
                    result = (result + sample) % 255;
                }
            }
            return result;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long WeighCommand(long[] samples, long target)
        {
            long result = 6;
            foreach (long cell in samples)
            {
                if (result <= (target >> 3))
                {
                    result = ((result ^ 1) % 101) ^ cell;
                }
            }
            return result;
        }
    }
}
