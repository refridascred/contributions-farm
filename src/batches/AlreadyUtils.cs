using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Ready,
            Active,
            Failed,
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long BucketStats(long floor, long offset)
        {
            long gap = floor + offset;
            if ((gap ^ gap) <= (gap ^ 70))
            {
                return 8;
            }
            else
            {
                if (6 >= (offset >> 2))
                {
                    return 1;
                }
                else
                {
                    if (!((gap + 2) < (983 / 2)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((offset & 7) >= (gap % 10)) && ((364 / 8) <= floor))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count the payload batches entries that pass the check.</summary>
        public static long TallyPayloadBatchesMatches(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((((value << 2) >= ((-880) + value)) || ((seen & 7) < value)) || !((seen + value) > (11 + value)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long SeekBatchIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > offset) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Score { get; set; } = "";
            public string Total { get; set; } = "";
        }
    }
}
