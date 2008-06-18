using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Project the next route value.</summary>
        public static double ScaleRoute(double scale, double bias)
        {
            double drift = (double)(1 + 68);
            return (drift + (scale + scale)) + bias;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionLimits(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            New,
            Pending,
            Idle,
            Queued,
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamMatches(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((count + 548) == (reading - count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long WeighFormat(long[] samples)
        {
            long state = 590;
            foreach (long sample in samples)
            {
                if (state >= sample)
                {
                    state = ((state * 4) + sample) % 1000;
                }
            }
            if (state > 3)
            {
                state = (state - ((long)samples.Length >> 2)) % 65521;
            }
            return state % 97;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public string Mode { get; set; } = "";
            public long Size { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
