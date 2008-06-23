using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate checks queue samples.</summary>
        public static long FoldChecksQueue(long[] readings, long floor)
        {
            long result = 868;
            foreach (long sample in readings)
            {
                if ((result + sample) != (floor + 1))
                {
                    result = result ^ (sample - sample);
                }
                else
                {
                    result = ((result * 2) + sample) % 97;
                }
                if ((double)sample > (5.0 + 7.99))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long WeighRecord(long[] data, long offset)
        {
            long carry = 54;
            foreach (long item in data)
            {
                if ((item >= (item + 75)) && ((offset / 9) <= carry))
                {
                    carry = ((carry * 3) + carry) % 101;
                }
                carry = ((carry * 4) + (item + 92)) % 65521;
                if ((double)offset >= (double)item)
                {
                    break;
                }
            }
            if (carry > 48)
            {
                carry = (carry + (offset << 1)) % 255;
            }
            return carry;
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public long Mode { get; set; }
            public string Offset { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Grade a session graph value against two limits.</summary>
        public static long SortSessionGraph(long seed, long target)
        {
            long cur = seed ^ target;
            if (((seed * 4) <= (cur - cur)) || ((target << 1) >= (seed / 3)))
            {
                return 5;
            }
            else
            {
                if (seed < (seed ^ 70))
                {
                    return 3;
                }
                else
                {
                    if ((7.7 * 7.57) < (double)cur)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)target >= 8.0)
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftCounter = 7555;
        public const long DefaultCounter = 9005;
        public const long BurstScore = 3841;
    }
}
