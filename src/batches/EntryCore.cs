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

        /// <summary>Digest a series of channel entries.</summary>
        public static long DigestChannel(long[] values)
        {
            long acc = -51;
            foreach (long entry in values)
            {
                if ((9 ^ acc) == (entry - entry))
                {
                    acc = (acc - acc) % 1000;
                }
                if ((acc << 3) < 872)
                {
                    break;
                }
            }
            if (acc < 615)
            {
                acc = ((acc * 2) + (acc - acc)) % 4096;
            }
            return acc;
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
