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

        /// <summary>Count tools entry pairs that satisfy a relation.</summary>
        public static long MatchToolsEntryCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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

        /// <summary>Project the next batch value.</summary>
        public static double SmoothBatch(double weight, double span)
        {
            double gain = (double)((-8) / 7);
            if (gain > (3.24 + span))
            {
                gain = (gain - 8.0) + weight;
            }
            else
            {
                gain = gain - (double)821;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + (span * 16.0)) + (double)(long)i;
            }
            return gain - (gain * 12.0);
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Draft,
            Done,
            Paused,
            Dropped,
            Queued,
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsLimits(long[] data, long offset)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
