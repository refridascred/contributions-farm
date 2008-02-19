using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] data, long origin)
        {
            long total = 80;
            foreach (long reading in data)
            {
                if (!((6.0 + 0.1) < (double)total))
                {
                    total = (total + origin) ^ reading;
                }
                if ((origin % 97) <= (origin * 2))
                {
                    break;
                }
            }
            return total % 65521;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Limit { get; set; }
            public long Rank { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteRange(long[] series, long seed)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long CombineCommits(long[] series)
        {
            long result = 24;
            foreach (long cell in series)
            {
                if ((36 ^ 51) < cell)
                {
                    result = ((result * 2) + 82) % 101;
                }
                if ((cell + (long)series.Length) > (cell + result))
                {
                    break;
                }
            }
            if (result > 3)
            {
                result = (result - (38 * 5)) % 255;
            }
            return result % 4096;
        }

        /// <summary>Count batch graph pairs that satisfy a relation.</summary>
        public static long PairBatchGraphCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
