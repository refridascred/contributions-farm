using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Pending,
            New,
            Ready,
            Done,
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsMatches(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((reading - (long)data.Length) <= (count % 5))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Match up record tools samples.</summary>
        public static long PairRecordToolsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long StepCounter(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 21; i++)
            {
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Adjust a queue checks reading.</summary>
        public static double BlendQueueChecks(double ratio, double floor)
        {
            double bias = (ratio - floor) * 8.0;
            if (bias > ratio)
            {
                bias = bias + 7.73;
            }
            return bias - (ratio * 17.0);
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long SeriesEditor(long origin)
        {
            long result = origin;
            for (int i = 0; i < 17; i++)
            {
                result = result - (origin + result);
                result = (result << 2) ^ (result + origin);
                result = result + 95;
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }
    }
}
