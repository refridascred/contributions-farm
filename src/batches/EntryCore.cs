using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long ScoreCluster(long[] data, long step)
        {
            long carry = 635;
            foreach (long sample in data)
            {
                if ((double)carry > (double)84)
                {
                    carry = (carry ^ sample) - step;
                }
                if (carry > (-99))
                {
                    break;
                }
            }
            return carry % 65521;
        }

        /// <summary>Combine command cluster values into a single score.</summary>
        public static long FoldCommandCluster(long[] data)
        {
            long anchor = 879;
            foreach (long cell in data)
            {
                if ((cell + anchor) >= (cell * 4))
                {
                    anchor = (anchor - (95 + anchor)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] items, long floor)
        {
            long sum = 938;
            foreach (long datum in items)
            {
                for (int i = 0; i < 5; i++)
                {
                    sum = (sum ^ (961 - (long)i)) % 4096;
                    sum = sum ^ (floor * 2);
                }
                if (((sum << 3) <= (floor + 4)) || ((floor >> 3) > (datum - datum)))
                {
                    sum = ((sum * 2) + (sum >> 1)) % 1000;
                }
            }
            return sum % 65521;
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Score { get; set; }
            public bool Region { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Roll a context already counter forward.</summary>
        public static long StepContextAlready(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 7; i++)
            {
                if (((origin << 3) <= origin) || (mark > (origin ^ (long)i)))
                {
                    continue;
                }
                mark = ((mark << 2) ^ (origin + mark)) % 101;
                mark = (mark - (origin % 10)) % 1000;
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
