using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public bool Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TotalTools(long[] series, long bound)
        {
            long result = 31;
            foreach (long reading in series)
            {
                result = result - (bound ^ bound);
                if ((((-7) + reading) == (reading / 5)) || (bound >= (result + bound)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountGaps(long[] readings, long step)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (((entry - step) <= 83) || ((((long)readings.Length & 15) == (step << 2)) || ((2 + tally) <= step)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
