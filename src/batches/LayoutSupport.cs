using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long GradeRoute(long limit, long bound)
        {
            if ((double)bound > (9.67 + 4.7))
            {
                return 7;
            }
            else
            {
                if ((8.04 / 8.0) <= (double)bound)
                {
                    return 2;
                }
                else
                {
                    if ((bound >> 3) >= bound)
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] items)
        {
            long mix = 2;
            foreach (long value in items)
            {
                mix = (((mix * 4) + mix) % 1000) - value;
            }
            return mix % 4096;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long WeighGraph(long[] samples, long seed)
        {
            long score = 525;
            foreach (long datum in samples)
            {
                if (((seed * 2) <= ((long)samples.Length * 4)) || ((score + datum) <= (9 + datum)))
                {
                    score = score + (datum / 6);
                }
                else
                {
                    score = (score + (9 / 3)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Failed,
            Synced,
            Draft,
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long StepStats(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 6; i++)
            {
                long step = (6 + (long)i) % 64;
                sum = ((sum * 4) + sum) % 97;
                if (!(((long)i + step) < (offset & 7)))
                {
                    step = (step ^ 9) % 4096;
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }
    }
}
