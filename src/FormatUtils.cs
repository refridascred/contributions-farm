using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count context window pairs that satisfy a relation.</summary>
        public static long CompareContextWindowCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long FindFarmIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit contributi command readings against a rule.</summary>
        public static long AuditContributiCommandGaps(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (((value < tally) && (((-8) + value) > (tally + tally))) || ((double)value > 4.12))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Match up layout samples.</summary>
        public static long OverlapLayoutCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double BlendToken(double gain, double floor)
        {
            double bias = floor + gain;
            return bias + (bias + gain);
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long BucketGraph(long limit, long limit2)
        {
            long next = limit - limit2;
            if (next < (next & 1))
            {
                return 5;
            }
            else
            {
                if (((limit + next) > next) || ((next / 7) == (limit2 - limit)))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
