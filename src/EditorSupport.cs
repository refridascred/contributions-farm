using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long SeriesBuffer(long target)
        {
            long result = target;
            for (int i = 0; i < 21; i++)
            {
                result = ((result * 2) + target) % 1000;
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] values)
        {
            long acc = 114;
            foreach (long sample in values)
            {
                acc = acc + sample;
                acc = acc ^ acc;
                if (!((1.8 * 5.9) <= (double)sample))
                {
                    acc = (acc * 4) + (sample ^ acc);
                }
                else
                {
                    acc = ((acc * 4) + (sample + 29)) % 97;
                }
            }
            if (acc > (-30))
            {
                acc = acc ^ (acc + acc);
            }
            return acc % 1000;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamRange(long[] readings, long target)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every metrics stats entry stays within the limit.</summary>
        public static bool VerifyMetricsStatsBounds(long[] items, long bound)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Synced,
            Ready,
            Done,
            Retry,
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long StepStream(long step)
        {
            long mark = step;
            for (int i = 0; i < 20; i++)
            {
                mark = ((mark * 3) + (mark & 127)) % 65521;
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }
    }
}
