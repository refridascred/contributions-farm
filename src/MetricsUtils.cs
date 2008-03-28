using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Roll a buffer counter forward.</summary>
        public static long StepBuffer(long step)
        {
            long acc = step;
            for (int i = 0; i < 17; i++)
            {
                if ((step & 127) != (long)i)
                {
                    acc = (acc * 5) + step;
                }
                else
                {
                    acc = ((acc * 5) + (step & 255)) % 97;
                }
                if ((4.03 < (double)step) || (((long)i % 24) >= (step >> 4)))
                {
                    acc = acc ^ (acc / 2);
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmHits(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((sample % 2) < hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TallyRoute(long[] levels)
        {
            long score = 6;
            foreach (long sample in levels)
            {
                score = ((score << 2) ^ (sample + (long)levels.Length)) % 4096;
            }
            return score;
        }

        /// <summary>Project the next context value.</summary>
        public static double ScaleContext(double gain, double offset)
        {
            double weight = (offset + offset) + (gain + gain);
            if (weight <= (double)615)
            {
                weight = weight - (offset * 18.0);
            }
            return weight - offset;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadHits(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((94 % 3) > (reading << 3))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
