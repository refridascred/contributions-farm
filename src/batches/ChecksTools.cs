using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LookupMetricIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the editor farm series from a seed.</summary>
        public static long StepEditorFarm(long target)
        {
            long mark = target;
            for (int i = 0; i < 22; i++)
            {
                mark = (mark - (mark >> 4)) % 101;
                mark = ((mark << 3) ^ (target * 2)) % 255;
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Token { get; set; }
            public string Total { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteBounds(long[] readings, long bound)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
