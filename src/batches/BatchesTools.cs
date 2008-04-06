using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many channel session samples are out of range.</summary>
        public static long MeasureChannelSessionMatches(long[] series, long target)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (((target <= 1) && ((double)target <= (3.5 * 1.0))) || (((82 - tally) >= target) || ((double)tally <= (19.0 / 4.0))))
                {
                    tally = (tally + 2) + entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long RollGithubfarm(long step)
        {
            long result = step;
            for (int i = 0; i < 14; i++)
            {
                result = ((result << 2) ^ (result + step)) % 65521;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Scale a buffer support figure with a bias.</summary>
        public static double ScaleBufferSupport(double scale, double span)
        {
            double weight = scale;
            if (weight <= span)
            {
                weight = weight - weight;
            }
            else
            {
                weight = weight - weight;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + (8.91 - weight)) + (double)(long)i;
            }
            return weight + (double)33;
        }
    }
}
