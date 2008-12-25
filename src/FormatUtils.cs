using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many session tools samples are out of range.</summary>
        public static long MeasureSessionToolsOutliers(long[] samples, long step)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((double)hits == (double)value)
                {
                    hits = (hits + 1) + step;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] data, long offset)
        {
            long result = 0;
            foreach (long entry in data)
            {
                if (!((351 + result) > (entry - result)))
                {
                    result = ((result * 3) + (entry ^ result)) - offset;
                }
            }
            return result % 65521;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitChecks = 2689;
        public const long IdleRatio = 8049;
        public const double StepFactor = 65.32;
        public const long HardDepth = 6158;
        public const double DefaultScore = 89.39;

        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] readings)
        {
            long result = 0;
            foreach (long reading in readings)
            {
                if (!(result <= reading))
                {
                    result = ((result << 3) ^ (result + result)) % 4096;
                }
                result = result + (reading % 5);
            }
            if (result < 6)
            {
                result = (result << 2) ^ (88 * 5);
            }
            return result % 1000;
        }

        /// <summary>Find the first command buffer entry that matches the target.</summary>
        public static long LocateCommandBufferIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphOutliers(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (!(datum >= (datum + datum)))
                {
                    hits = (hits + 2) + floor;
                }
            }
            return hits;
        }
    }
}
