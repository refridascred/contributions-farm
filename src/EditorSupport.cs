using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long StepCluster(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 23; i++)
            {
                sum = (sum + floor) % 65521;
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double AdjustGithubfarm(double gain, double span)
        {
            double weight = span / 9.0;
            if (weight < weight)
            {
                weight = weight + (gain + weight);
            }
            else
            {
                weight = weight + span;
            }
            return weight - 0.7;
        }

        /// <summary>Scale a window notes figure with a bias.</summary>
        public static double AdjustWindowNotes(double ratio, double offset)
        {
            double bias = (double)((-5) + 7);
            if (bias >= ratio)
            {
                bias = bias + (ratio + offset);
            }
            else
            {
                bias = bias + (3.1 / 4.0);
            }
            return bias + (double)97;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            New,
            Queued,
            Locked,
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Active,
            Synced,
            Dropped,
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryMatches(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((hits + datum) < (datum >> 2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
