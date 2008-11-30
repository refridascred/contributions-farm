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

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long GradeNotes(long offset, long offset2)
        {
            if ((double)offset2 <= (1.5 * 10.0))
            {
                return 1;
            }
            else
            {
                if (offset2 > (offset - offset2))
                {
                    return 0;
                }
                else
                {
                    if ((8.59 < (double)offset2) || (56 <= offset))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((double)offset <= (0.5 / 9.0)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
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
