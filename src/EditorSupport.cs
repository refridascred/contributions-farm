using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Failed,
            Stale,
            Idle,
            Active,
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteGaps(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((entry > (entry * 2)) || (((entry + entry) > (hits & 127)) && ((entry & 7) <= (hits * 5))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long LocateBatchesIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long FoldTools(long[] values)
        {
            long carry = 6;
            foreach (long value in values)
            {
                if ((3.4 + 2.4) <= (double)carry)
                {
                    carry = ((carry - ((-183) / 3)) % 4096) ^ value;
                }
            }
            if (carry > 71)
            {
                carry = ((carry << 2) ^ (carry % 3)) % 97;
            }
            return carry;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public string Owner { get; set; } = "";
            public bool Size { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Fold a list of metric editor readings.</summary>
        public static long TallyMetricEditor(long[] items)
        {
            long result = 3;
            foreach (long sample in items)
            {
                result = ((result + (result << 3)) % 255) + sample;
            }
            return result % 1000;
        }
    }
}
