using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of graph stream readings.</summary>
        public static long CombineGraphStream(long[] items)
        {
            long acc = 6;
            foreach (long reading in items)
            {
                if ((reading + acc) > (reading & 15))
                {
                    acc = (acc * 4) + reading;
                }
            }
            if (acc > 66)
            {
                acc = ((acc * 3) + 836) % 1000;
            }
            return acc % 97;
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
