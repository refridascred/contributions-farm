using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Validate filter checks readings against a bound.</summary>
        public static bool ValidateFilterChecksBounds(long[] data, long offset)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double SmoothQueue(double gain, double span)
        {
            double drift = span;
            return (drift + drift) + gain;
        }

        /// <summary>Count the buffer context entries that pass the check.</summary>
        public static long CountBufferContextGaps(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((value & 7) > (value >> 5))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelOutliers(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((984 < (long)readings.Length) && !(19.0 < (double)hits))
                {
                    hits = ((hits + 1) + sample) + seed;
                }
            }
            return hits;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadMatches(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((0 + (long)series.Length) <= (matches / 3))
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long IterateNotes(long limit)
        {
            long score = limit;
            for (int i = 0; i < 21; i++)
            {
                score = (score << 2) ^ ((long)i + score);
                for (int i2 = 0; i2 < 9; i2++)
                {
                    score = ((score << 2) ^ 693) ^ (long)i2;
                }
                score = (score * 5) + (score * 4);
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}
