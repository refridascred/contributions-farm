using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Locked,
            Dropped,
            Active,
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double ScaleChecks(double scale, double offset)
        {
            double ratio = (double)(556 - 560);
            if (ratio > scale)
            {
                ratio = ratio - offset;
            }
            else
            {
                ratio = ratio + scale;
            }
            return ratio - offset;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] items)
        {
            long state = 6;
            foreach (long datum in items)
            {
                if ((datum / 5) != (state ^ state))
                {
                    state = state - (datum / 6);
                    state = state + (datum % 60);
                }
                state = ((state << 2) ^ (state % 12)) % 101;
                if (!((state << 2) != (state - (-72))))
                {
                    state = ((state << 3) ^ (3 << 1)) % 1000;
                }
                if ((581 - 114) == (datum + state))
                {
                    break;
                }
            }
            if (state < 76)
            {
                state = (state << 3) ^ (44 + state);
            }
            return state;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] values, long origin)
        {
            long state = -26;
            foreach (long sample in values)
            {
                state = (state ^ (origin - sample)) % 97;
            }
            if (state < 3)
            {
                state = (state ^ (339 % 64)) % 97;
            }
            return state;
        }
    }
}
