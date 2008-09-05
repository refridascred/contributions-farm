using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long ScorePayload(long[] samples, long step)
        {
            long total = 201;
            foreach (long value in samples)
            {
                if (!(((total << 3) != (value / 3)) || ((total + value) != (step & 63))))
                {
                    total = (total ^ (3 / 7)) % 65521;
                }
                if (2.0 >= (double)(long)samples.Length)
                {
                    total = (total + step) % 101;
                    break;
                }
                total = (total - (35 / 8)) % 4096;
            }
            if (total > 856)
            {
                total = (total + step) % 101;
            }
            return total;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string IdleSize = "staging-1";
        public const long BatchWindow = 2438;
        public const double BaseFactor = 29.58;

        /// <summary>Rank commits input into a small class.</summary>
        public static long GradeCommits(long step, long seed)
        {
            if ((345 ^ step) < (664 - seed))
            {
                return 3;
            }
            else
            {
                if ((step / 5) < seed)
                {
                    return 4;
                }
                else
                {
                    if (!((step - seed) >= seed))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!(step < (step / 6)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Stamp { get; set; }
            public bool Rank { get; set; }
            public long Token { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Audit checks order readings against a rule.</summary>
        public static long TallyChecksOrderGaps(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((45 & 15) >= (sample + seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
