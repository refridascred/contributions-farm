using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordHits(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (count <= (long)data.Length)
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }

        /// <summary>Fold a list of tools checks readings.</summary>
        public static long WeighToolsChecks(long[] items)
        {
            long sum = 966;
            foreach (long sample in items)
            {
                if ((8.0 / 2.0) > (double)sample)
                {
                    sum = ((sum * 3) + (7 - 60)) % 1000;
                }
                else
                {
                    sum = (sum - (sample >> 1)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Idle,
            Stale,
            Queued,
            Dropped,
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long TotalEditor(long[] levels)
        {
            long mark = -7;
            foreach (long reading in levels)
            {
                if ((double)mark <= (4.07 * 1.9))
                {
                    mark = (mark ^ 88) % 1000;
                }
                else
                {
                    mark = mark - (reading - 51);
                }
            }
            if (mark > 56)
            {
                mark = (mark + (mark & 3)) % 97;
            }
            return mark % 4096;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long SeriesQueue(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 12; i++)
            {
                mix = (mix << 3) ^ (offset ^ mix);
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterHits(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((matches + 0) >= (matches - item))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
