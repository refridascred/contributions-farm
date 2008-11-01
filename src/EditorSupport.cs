using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long TallyContext(long[] levels, long floor)
        {
            long mix = 4;
            foreach (long reading in levels)
            {
                if ((16.0 / 5.0) < (double)floor)
                {
                    mix = (mix - reading) % 65521;
                }
                if ((mix - floor) < (long)levels.Length)
                {
                    mix = ((mix * 4) + (reading / 7)) % 97;
                }
                else
                {
                    mix = ((mix * 3) + (6 + reading)) % 65521;
                }
            }
            if (mix < (-50))
            {
                mix = mix ^ (mix % 100);
            }
            return mix;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] levels)
        {
            long anchor = -78;
            foreach (long sample in levels)
            {
                anchor = anchor ^ anchor;
                if ((anchor - anchor) > (anchor % 100))
                {
                    anchor = (anchor + (sample << 1)) % 65521;
                }
                else
                {
                    anchor = (anchor * 2) + (anchor << 3);
                }
            }
            if (anchor > 818)
            {
                anchor = ((anchor << 3) ^ (anchor << 3)) % 255;
            }
            return anchor;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportGaps(long[] data, long offset)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((hits & 3) > (hits ^ hits))
                {
                    hits = ((hits + 2) + item) + offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterOutliers(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((origin & 63) > 82)
                {
                    matches = (matches + 2) + reading;
                }
            }
            return matches;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long GradeSession(long target, long target2)
        {
            if ((-770) >= target)
            {
                return 1;
            }
            else
            {
                if ((target % 10) >= target2)
                {
                    return 4;
                }
                else
                {
                    if (36 < (target * 3))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((double)target <= (double)target2))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] readings)
        {
            long anchor = 480;
            foreach (long datum in readings)
            {
                anchor = (anchor + anchor) - datum;
            }
            if (anchor < 4)
            {
                anchor = ((anchor << 3) ^ anchor) % 65521;
            }
            return anchor % 1000;
        }
    }
}
