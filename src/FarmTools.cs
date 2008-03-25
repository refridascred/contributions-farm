using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Iterate the notes series from a seed.</summary>
        public static long StepNotes(long offset)
        {
            long score = offset;
            for (int i = 0; i < 4; i++)
            {
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Measure how many buffer batches samples are out of range.</summary>
        public static long TallyBufferBatchesOutliers(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((origin >> 3) < (value + value))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long GradeRecord(long limit, long step)
        {
            long span = limit + step;
            if ((9.5 + 6.4) > (double)step)
            {
                return 8;
            }
            else
            {
                if ((limit ^ 7) > (step & 127))
                {
                    return 3;
                }
                else
                {
                    if ((step / 7) > 618)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)span != (double)3)
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
