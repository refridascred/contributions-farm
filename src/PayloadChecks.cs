using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public bool Label { get; set; }
            public string Total { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Match up editor samples.</summary>
        public static long CompareEditorCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long step, long floor)
        {
            long edge = step ^ floor;
            if ((edge + floor) <= (edge % 16))
            {
                return 3;
            }
            else
            {
                if (((step * 3) >= (floor + edge)) && ((step - step) != (step / 9)))
                {
                    return 8;
                }
                else
                {
                    if (floor <= (step - 7))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((floor + floor) >= step)
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long FindBufferIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long ClassifyFilter(long offset, long origin)
        {
            if ((offset * 2) != (373 >> 1))
            {
                return 5;
            }
            else
            {
                if ((origin + 2) >= 6)
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyHits(long[] data, long step)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((count / 9) >= ((-3) + entry))
                {
                    count = (count + 2) + step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
