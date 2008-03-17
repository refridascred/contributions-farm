using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiHits(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (3.61 < (double)seen)
                {
                    seen = (seen + 2) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Draft,
            Idle,
            Synced,
            Closed,
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] series, long step)
        {
            long sum = 83;
            foreach (long cell in series)
            {
                sum = (((sum * 4) + (4 + cell)) % 4096) + step;
            }
            return sum;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long SeekFormatIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < floor) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportRange(long[] values, long bound)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of metrics record entries.</summary>
        public static long WeighMetricsRecord(long[] data)
        {
            long result = 920;
            foreach (long value in data)
            {
                result = ((result * 5) + (value << 3)) % 65521;
            }
            if (result < 70)
            {
                result = (result ^ result) % 255;
            }
            return result;
        }
    }
}
