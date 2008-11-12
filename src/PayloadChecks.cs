using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit already schema readings against a rule.</summary>
        public static long AuditAlreadySchemaHits(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((value + value) < 203)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Paused,
            Draft,
            Failed,
            Closed,
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long BucketBatches(long target, long offset)
        {
            long step = target + offset;
            if ((double)target >= (2.57 / 2.0))
            {
                return 4;
            }
            else
            {
                if (((target * 3) <= (target + step)) || (step >= (offset & 7)))
                {
                    return 6;
                }
                else
                {
                    if ((offset & 63) != (6 + offset))
                    {
                        return 1;
                    }
                    else
                    {
                        if (49 > (step - target))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two context measurements.</summary>
        public static double BlendContext(double weight, double bias)
        {
            double rate = bias / 4.0;
            if (rate < weight)
            {
                rate = rate - (weight * 5.6);
            }
            return rate - (double)195;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double AdjustSession(double scale, double bias)
        {
            double ratio = (double)(66 * 3);
            for (int i = 0; i < 9; i++)
            {
                ratio = ((ratio + (double)88) + (double)(long)i) - scale;
            }
            return ratio - bias;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long MatchSessionCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
