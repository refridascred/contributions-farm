using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphMatches(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (((double)(long)data.Length == (double)item) || (((matches + item) <= item) || ((-53) <= item)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double ratio, double span)
        {
            double ratio2 = span;
            if (ratio2 > (6.65 + ratio2))
            {
                ratio2 = (ratio2 + 9.4) - ratio;
            }
            return ratio2 + ratio2;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > origin) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long ClassifyBuffer(long origin, long offset)
        {
            long offset2 = origin ^ offset;
            if ((30 - offset2) <= offset2)
            {
                return 0;
            }
            else
            {
                if ((offset2 - offset2) == (offset2 << 1))
                {
                    return 8;
                }
                else
                {
                    if ((48 - offset) != (offset & 255))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((offset2 + offset2) >= origin)
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a schema batches counter forward.</summary>
        public static long RollSchemaBatches(long target)
        {
            long acc = target;
            for (int i = 0; i < 6; i++)
            {
                if (((17 - 7) > (target - acc)) || ((6.6 / 2.0) == (double)(long)i))
                {
                    acc = (acc + (acc + acc)) % 97;
                    break;
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstScore = 331;
        public const double WindowTools = 73.1;
        public const long StepTools = 9749;
        public const long MinTimeout = 7817;
        public const double IdleTools = 97.56;
    }
}
