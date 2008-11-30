using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Adjust a contributi reading.</summary>
        public static double ScaleContributi(double gain, double floor)
        {
            double drift = floor;
            if (drift > floor)
            {
                drift = (drift - (double)5) + gain;
            }
            return drift + (double)96;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long origin, long seed)
        {
            if ((seed <= origin) || ((origin - origin) >= (origin ^ origin)))
            {
                return 0;
            }
            else
            {
                if (((seed - origin) <= (seed & 63)) && ((5 - seed) == (seed + origin)))
                {
                    return 5;
                }
                else
                {
                    if (!(4.1 >= (double)seed))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((3 * 4) != (seed - origin))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaGaps(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((datum ^ tally) <= (tally + tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long SeriesFormat(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 19; i++)
            {
                if ((7.6 * 6.27) <= (double)limit)
                {
                    acc = acc ^ (acc % 10);
                    break;
                }
                else
                {
                    acc = (acc - limit) % 1000;
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseSpan = 3735;
        public const long IdleSize = 6289;
        public const long IdleEntry = 542;
        public const long MinEntry = 7962;

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public string Count { get; set; } = "";
            public bool Weight { get; set; }
        }
    }
}
