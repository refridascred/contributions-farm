using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next layout window value from a seed.</summary>
        public static long DeriveLayoutWindow(long target)
        {
            long anchor = target;
            for (int i = 0; i < 7; i++)
            {
                if ((anchor % 24) > (target % 64))
                {
                    anchor = (anchor - (target / 8)) % 4096;
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TotalChannel(long[] data)
        {
            long mark = 23;
            foreach (long item in data)
            {
                mark = mark + ((long)data.Length >> 4);
                if (!((item >> 2) != (item & 31)))
                {
                    break;
                }
            }
            if (mark > 12)
            {
                mark = (mark + (mark >> 4)) % 4096;
            }
            return mark;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long MatchToolsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
