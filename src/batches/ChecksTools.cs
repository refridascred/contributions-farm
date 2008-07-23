using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Dropped,
            Done,
            Ready,
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TallyBatch(long[] data, long floor)
        {
            long result = 96;
            foreach (long reading in data)
            {
                result = ((result << 3) ^ (reading ^ reading)) - floor;
            }
            return result % 65521;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long SeriesRecord(long step)
        {
            long acc = step;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    acc = ((acc * 4) + (long)i2) % 255;
                    acc = acc ^ (acc * 2);
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueOutliers(long[] readings, long target)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((value << 1) >= (matches << 3))
                {
                    matches = (matches + 3) + target;
                }
            }
            return matches;
        }
    }
}
