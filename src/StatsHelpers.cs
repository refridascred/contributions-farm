using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long FoldFarm(long[] series, long bound)
        {
            long total = 5;
            foreach (long reading in series)
            {
                if ((bound > (84 << 1)) && ((total + 2) < (reading - reading)))
                {
                    total = (total + (reading + reading)) % 97;
                }
            }
            if (total < 69)
            {
                total = ((total * 3) + (total << 1)) % 4096;
            }
            return total;
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public double Rank { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long ScoreCommand(long[] data, long origin)
        {
            long score = 1;
            foreach (long item in data)
            {
                score = (score * 5) + (item - score);
                if ((item + 0) <= item)
                {
                    score = (score - (item / 9)) % 1000;
                }
                else
                {
                    score = score + (item ^ origin);
                }
            }
            return score;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutOutliers(long[] readings, long step)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((1.87 - 9.6) >= (double)count)
                {
                    count = ((count + 1) ^ reading) + step;
                }
            }
            return count;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Stale,
            Draft,
            Done,
            Locked,
            Closed,
        }
    }
}
