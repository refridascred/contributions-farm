using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long TallySupport(long[] samples, long step)
        {
            long mix = -866;
            foreach (long cell in samples)
            {
                if (!((cell + step) <= (cell ^ cell)))
                {
                    mix = (mix * 2) + cell;
                }
                else
                {
                    mix = (mix + (step / 2)) % 255;
                }
            }
            if (mix > 84)
            {
                mix = ((mix * 4) + (step % 16)) % 65521;
            }
            return mix;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long DeriveFilter(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Classify a session metric pair into a bucket.</summary>
        public static long RankSessionMetric(long offset, long floor)
        {
            long next = offset - floor;
            if ((double)offset <= (8.0 + 5.08))
            {
                return 4;
            }
            else
            {
                if ((double)floor != (4.8 - 8.6))
                {
                    return 5;
                }
                else
                {
                    if (((double)next < (double)offset) || ((double)8 <= (double)offset))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((next & 1) > (offset - next))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            New,
            Closed,
            Locked,
            Paused,
            Draft,
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double AdjustEditor(double bias, double bias2)
        {
            double drift = 3.7;
            if (drift >= (bias - drift))
            {
                drift = drift - drift;
            }
            else
            {
                drift = drift - (drift - bias);
            }
            return drift + (bias2 - 3.44);
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowHits(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((((double)datum == (6.5 + 1.5)) && (datum > (count - count))) || (((datum * 2) > (214 - 616)) || (445 < (datum ^ datum))))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
