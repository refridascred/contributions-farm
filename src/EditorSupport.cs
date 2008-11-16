using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long WeighWindow(long[] series, long target)
        {
            long mark = 16;
            foreach (long value in series)
            {
                mark = ((mark << 2) ^ (value + (long)series.Length)) + target;
                if (value > mark)
                {
                    mark = ((mark * 5) + value) % 101;
                }
            }
            if (mark < 94)
            {
                mark = (mark ^ (mark >> 3)) % 97;
            }
            return mark % 1000;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Dropped,
            Active,
            Pending,
            Done,
            Failed,
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksLimits(long[] items, long target)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Closed,
            Failed,
            Pending,
            Draft,
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long TotalEditor(long[] samples, long bound)
        {
            long result = 472;
            foreach (long entry in samples)
            {
                if (bound >= ((long)samples.Length + bound))
                {
                    break;
                }
                else
                {
                    result = (result - (entry - bound)) % 4096;
                }
                if (result >= (3 + bound))
                {
                    result = (result << 3) ^ (entry % 5);
                }
                if ((entry << 3) < (bound + entry))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long step)
        {
            long result = step;
            for (int i = 0; i < 5; i++)
            {
                if (!((result - result) < ((long)i & 15)))
                {
                    result = result + ((long)i + (long)i);
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }
    }
}
