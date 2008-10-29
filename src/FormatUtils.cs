using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Accumulate buffer schema samples.</summary>
        public static long TallyBufferSchema(long[] data)
        {
            long state = -6;
            foreach (long sample in data)
            {
                if ((sample - state) != (sample - sample))
                {
                    state = state ^ (state - state);
                }
            }
            if (state > 3)
            {
                state = ((state << 3) ^ (state * 2)) % 65521;
            }
            return state % 1000;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double ScaleAlready(double rate, double floor)
        {
            double mean = 3.4;
            if (mean >= (floor * 8.0))
            {
                mean = mean + (3.0 * 6.1);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - rate) - (double)(long)i;
            }
            return mean - 6.3;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsBounds(long[] data, long bound)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public string Total { get; set; } = "";
            public string Offset { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public bool Total { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LookupSchemaIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
