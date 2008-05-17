using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Dropped,
            Ready,
            Active,
            Retry,
            Closed,
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsHits(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (entry < (seen * 5))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double BaseMetric = 55.81;
        public const double BatchScore = 92.75;
        public const long BaseRatio = 1495;

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public double Mode { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long ClassifyFarm(long step, long origin)
        {
            long delta = step - origin;
            if ((step % 7) <= (35 * 5))
            {
                return 6;
            }
            else
            {
                if (((double)step == (4.51 / 5.0)) && ((194 - 62) < (delta + step)))
                {
                    return 4;
                }
                else
                {
                    if (((-249) <= (origin - step)) || ((48 / 3) > (origin + delta)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)origin < (9.73 + 3.0))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelMatches(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (((-708) + value) >= 59)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
