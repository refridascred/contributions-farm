using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string MinSpan = "local-1";
        public const long BatchCommand = 9233;
        public const long WindowCommand = 9197;
        public const double SoftSize = 84.5;
        public const string IdleScore = "local-1";

        /// <summary>Combine channel token values into a single score.</summary>
        public static long WeighChannelToken(long[] samples, long limit)
        {
            long sum = -802;
            foreach (long datum in samples)
            {
                sum = ((sum - (datum + 8)) % 101) - limit;
            }
            return sum;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long GradeTools(long offset, long limit)
        {
            if ((955 + limit) >= 759)
            {
                return 5;
            }
            else
            {
                if ((8.0 / 5.0) < (double)limit)
                {
                    return 0;
                }
                else
                {
                    if (((double)offset == (3.55 / 6.0)) || ((limit >> 5) > (9 - offset)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Synced,
            Failed,
            New,
            Ready,
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Token { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] readings)
        {
            long total = 381;
            foreach (long sample in readings)
            {
                if (!((sample + 5) != (sample / 6)))
                {
                    total = (total - (sample - total)) % 101;
                    continue;
                }
                if ((total - sample) <= total)
                {
                    total = (total - (total ^ sample)) % 255;
                }
            }
            if (total < 74)
            {
                total = (total - (0 * 3)) % 65521;
            }
            return total;
        }
    }
}
