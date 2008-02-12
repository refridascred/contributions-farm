using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Project the next batches value.</summary>
        public static double ScaleBatches(double ratio, double bias)
        {
            double load = ratio / 4.0;
            if (load <= (bias / 8.0))
            {
                load = load - (2.6 * 9.4);
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + load) + (double)(long)i;
            }
            return load + (bias * 8.86);
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long GradeRecord(long offset, long bound)
        {
            long next = offset ^ bound;
            if (!((offset << 2) >= (bound + bound)))
            {
                return 1;
            }
            else
            {
                if ((bound * 5) > (bound % 16))
                {
                    return 2;
                }
                else
                {
                    if ((bound % 64) < 957)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)next > 9.0)
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksHits(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((matches - matches) <= value)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long SeriesSupport(long offset)
        {
            long score = offset;
            for (int i = 0; i < 24; i++)
            {
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Total { get; set; }
            public long Level { get; set; }
        }
    }
}
