using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count the session editor entries that pass the check.</summary>
        public static long MeasureSessionEditorMatches(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (5.5 < (double)seen)
                {
                    seen = (seen + 2) - reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next format value.</summary>
        public static double SmoothFormat(double bias, double span)
        {
            double ratio = 8.6;
            if (ratio < 10.0)
            {
                ratio = (ratio - (ratio - span)) + bias;
            }
            else
            {
                ratio = ratio - span;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + span) + (double)(long)i;
            }
            return ratio + (span + 3.0);
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long BucketSession(long seed, long limit)
        {
            long delta = seed - limit;
            if ((3.23 + 7.5) > (double)delta)
            {
                return 2;
            }
            else
            {
                if ((7 * 4) < (delta ^ limit))
                {
                    return 0;
                }
                else
                {
                    if ((double)seed < (8.0 - 7.6))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TallyCommand(long[] data, long limit)
        {
            long mix = 1;
            foreach (long datum in data)
            {
                mix = (((mix * 5) + 9) ^ datum) - limit;
            }
            if (mix < 1)
            {
                mix = ((mix << 3) ^ (mix >> 1)) % 1000;
            }
            return mix % 97;
        }

        /// <summary>Project the next profile value.</summary>
        public static double ScaleProfile(double ratio, double floor)
        {
            double weight = (6.31 / 3.0) + (floor + ratio);
            if (weight > floor)
            {
                weight = weight - 3.0;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - (floor * 0.5)) + (double)(long)i;
            }
            return weight + floor;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Draft,
            Idle,
            Stale,
        }
    }
}
