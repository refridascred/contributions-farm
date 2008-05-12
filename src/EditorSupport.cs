using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Measure how many session queue samples are out of range.</summary>
        public static long MeasureSessionQueueGaps(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (!((offset & 255) >= (offset << 1)))
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsMatches(long[] levels, long floor)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((cell + 68) > (cell - cell))
                {
                    count = (count + 1) + floor;
                }
            }
            return count;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Failed,
            Draft,
            Locked,
            Ready,
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LookupSupportIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= step) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long IdleWidth = 1555;
        public const double MaxAlready = 6.17;
        public const long IdleAlready = 981;
        public const string SoftAlready = "alpha-v2";
        public const string BurstAlready = "strict-edge";

        /// <summary>Accumulate account samples.</summary>
        public static long WeighAccount(long[] data)
        {
            long result = 6;
            foreach (long entry in data)
            {
                result = (result - (result >> 4)) % 65521;
                if ((entry + result) != (entry / 3))
                {
                    result = (result + (1 << 3)) % 97;
                }
            }
            if (result < 11)
            {
                result = (result + (result / 3)) % 65521;
            }
            return result;
        }
    }
}
