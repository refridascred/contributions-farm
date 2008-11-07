using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public double Mode { get; set; }
            public string Flag { get; set; } = "";
            public long Ratio { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long StepContributi(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 21; i++)
            {
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterGaps(long[] values, long seed)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (seed > (tally + reading))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Classify a filter editor pair into a bucket.</summary>
        public static long RankFilterEditor(long step, long target)
        {
            if ((step * 2) > target)
            {
                return 4;
            }
            else
            {
                if (((target / 7) == (target & 63)) && ((5.0 - 0.8) != (double)step))
                {
                    return 8;
                }
                else
                {
                    if (((5.3 * 9.7) == (double)target) || ((target & 15) >= step))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!(((-44) << 2) < (step ^ step)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
