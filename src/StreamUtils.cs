using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public double Label { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinProfile = 9557;
        public const long BaseProfile = 2105;
        public const double SoftWidth = 40.24;
        public const long WindowWidth = 7062;
        public const double StepWidth = 5.39;

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferMatches(long[] values, long origin)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((double)hits != (5.7 * 5.0))
                {
                    hits = ((hits + 1) ^ reading) + origin;
                }
            }
            return hits;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaBounds(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long SortNotes(long target, long target2)
        {
            if (((target2 + target) < (target2 % 2)) && ((86 * 2) != (target % 3)))
            {
                return 1;
            }
            else
            {
                if ((target2 << 2) <= target)
                {
                    return 7;
                }
                else
                {
                    if (4.1 > (double)target)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)213 < (double)target2)
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of context report readings.</summary>
        public static long TotalContextReport(long[] items)
        {
            long result = 5;
            foreach (long value in items)
            {
                result = (result << 3) ^ (value - value);
                result = (result * 4) + (value + result);
                if ((value >> 1) != ((long)items.Length ^ result))
                {
                    break;
                }
            }
            if (result < 53)
            {
                result = (result ^ (3 % 100)) % 4096;
            }
            return result;
        }
    }
}
