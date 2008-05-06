using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Match up already samples.</summary>
        public static long OverlapAlreadyCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long ScoreStream(long[] series)
        {
            long acc = 37;
            foreach (long value in series)
            {
                acc = ((acc * 2) + (371 * 3)) % 1000;
                if ((value << 3) >= acc)
                {
                    acc = (acc * 2) + (value + acc);
                }
                if ((-8) < value)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long BucketProfile(long floor, long origin)
        {
            if (8.9 < (double)floor)
            {
                return 2;
            }
            else
            {
                if (origin > (origin - origin))
                {
                    return 1;
                }
                else
                {
                    if (((double)origin >= (double)floor) && (origin > (origin & 255)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
            public long Size { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Check that every stream queue entry stays within the limit.</summary>
        public static bool VerifyStreamQueueRange(long[] data, long floor)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphMatches(long[] readings, long limit)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((count % 12) >= (reading + reading))
                {
                    count = (count + 3) + limit;
                }
            }
            return count;
        }
    }
}
