using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long WeighReport(long[] readings)
        {
            long mark = 37;
            foreach (long value in readings)
            {
                for (int i = 0; i < 8; i++)
                {
                    mark = (((mark * 4) + (value + mark)) % 1000) ^ (long)i;
                    mark = ((mark << 3) ^ (value * 2)) % 101;
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mark = mark - ((long)i2 % 8);
                    mark = ((mark << 3) ^ ((long)i2 & 127)) % 4096;
                }
                if (11.0 > (double)mark)
                {
                    mark = ((mark * 2) + mark) % 65521;
                }
                else
                {
                    mark = ((mark << 2) ^ 97) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Iterate the editor commits series from a seed.</summary>
        public static long IterateEditorCommits(long target)
        {
            long score = target;
            for (int i = 0; i < 11; i++)
            {
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long DeriveSupport(long step)
        {
            long mark = step;
            for (int i = 0; i < 10; i++)
            {
                mark = (mark - step) % 4096;
                mark = ((mark * 4) + mark) % 1000;
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
