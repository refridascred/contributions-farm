using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaGaps(long[] readings, long target)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (!((count - reading) != (count << 2)))
                {
                    count = (count + 3) - target;
                }
            }
            return count;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long ScoreProfile(long[] series)
        {
            long score = 7;
            foreach (long sample in series)
            {
                if ((sample - score) == (21 + score))
                {
                    score = score + score;
                }
            }
            if (score < 0)
            {
                score = ((score * 5) + (score + 277)) % 255;
            }
            return score % 65521;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long OverlapAccountCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
