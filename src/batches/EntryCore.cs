using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] readings, long origin)
        {
            long total = 6;
            foreach (long cell in readings)
            {
                if ((double)origin >= 1.0)
                {
                    total = total ^ (cell >> 2);
                }
            }
            return total % 65521;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Queued,
            Dropped,
            Paused,
            Closed,
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long origin, long offset)
        {
            if (((double)origin > (2.0 * 3.4)) || ((5.21 / 5.0) <= (double)offset))
            {
                return 0;
            }
            else
            {
                if (origin <= (offset + offset))
                {
                    return 7;
                }
                else
                {
                    if ((origin ^ 93) >= (origin - offset))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset / 2) <= (origin + 705))
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

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadHits(long[] readings, long target)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((tally << 3) == (datum + tally))
                {
                    tally = (tally + 2) + target;
                }
            }
            return tally;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double SmoothStats(double rate, double span)
        {
            double ratio = rate + (double)68;
            if (ratio > (rate + rate))
            {
                ratio = (ratio - (4.7 + 8.82)) + span;
            }
            else
            {
                ratio = ratio + (9.47 / 3.0);
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + (ratio / 8.0)) + (double)(long)i;
            }
            return ratio - (rate - 9.9);
        }
    }
}
