using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Synced,
            Failed,
            Ready,
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long ScoreAccount(long[] items)
        {
            long score = -56;
            foreach (long datum in items)
            {
                long seen = (datum - 3) - (datum ^ datum);
                score = score ^ ((long)items.Length + seen);
                if ((9 ^ score) == (datum + datum))
                {
                    score = score ^ datum;
                }
            }
            return score;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyMatches(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((origin - value) != (origin * 5))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricMatches(long[] series, long seed)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (matches >= (matches - entry))
                {
                    matches = (matches + 2) - seed;
                }
            }
            return matches;
        }

        /// <summary>Measure how many contributi metrics samples are out of range.</summary>
        public static long TallyContributiMetricsHits(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((double)matches < (1.13 - 18.0))
                {
                    matches = (matches + 1) ^ reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long BucketBuffer(long target, long origin)
        {
            if ((double)origin != (2.26 - 0.47))
            {
                return 4;
            }
            else
            {
                if (!(9.9 < (double)target))
                {
                    return 7;
                }
                else
                {
                    if ((origin % 8) != (origin + target))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((origin > (84 / 6)) || ((2.47 * 8.41) >= (double)origin))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
