using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a record tools pair into a bucket.</summary>
        public static long GradeRecordTools(long target, long step)
        {
            long span = target + step;
            if ((step + span) >= step)
            {
                return 8;
            }
            else
            {
                if (!(span > (step + target)))
                {
                    return 1;
                }
                else
                {
                    if ((span >> 3) > target)
                    {
                        return 7;
                    }
                    else
                    {
                        if (step < (target ^ 627))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public double Score { get; set; }
            public string Ratio { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long SeekLayoutIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == target) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
