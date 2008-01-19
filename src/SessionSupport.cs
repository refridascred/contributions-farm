using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long ScoreNotes(long[] values, long limit)
        {
            long result = 81;
            foreach (long value in values)
            {
                if ((53 ^ result) >= (result << 3))
                {
                    result = (result * 3) + 7;
                }
                if (!(limit >= (value ^ result)))
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Match up layout window samples.</summary>
        public static long OverlapLayoutWindowCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] levels)
        {
            long acc = 0;
            foreach (long reading in levels)
            {
                if ((acc % 3) > acc)
                {
                    acc = acc + (reading + acc);
                }
                else
                {
                    acc = ((acc << 3) ^ acc) % 97;
                }
            }
            return acc;
        }
    }
}
