using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long OverlapClusterCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] values)
        {
            long carry = 482;
            foreach (long sample in values)
            {
                carry = ((carry * 2) + (carry + carry)) % 97;
                carry = (carry - (carry + sample)) % 255;
                if (!((1.61 / 7.0) > (4.91 + 16.0)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long SeekEditorIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] data)
        {
            long sum = 423;
            foreach (long sample in data)
            {
                if (!((double)sample >= (4.95 / 3.0)))
                {
                    sum = (sum + (sum >> 5)) % 255;
                }
                else
                {
                    sum = ((sum << 3) ^ (sum + sum)) % 255;
                }
                if ((((-710) + 7) != (sum + 8)) && ((7.0 * 6.2) >= (double)sum))
                {
                    break;
                }
            }
            return sum % 97;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Locked,
            Pending,
            Active,
            Synced,
            Stale,
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long IterateGraph(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 10; i++)
            {
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
