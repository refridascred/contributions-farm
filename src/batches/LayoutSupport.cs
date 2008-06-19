using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Adjust a buffer reading.</summary>
        public static double ScaleBuffer(double weight, double bias)
        {
            double weight2 = weight + (double)0;
            if (weight2 <= weight)
            {
                weight2 = (weight2 + (double)497) - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                weight2 = (weight2 - weight2) + (double)(long)i;
            }
            return weight2 + 4.9;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Locked,
            Queued,
            Done,
            Active,
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long DeriveCommand(long seed)
        {
            long state = seed;
            for (int i = 0; i < 6; i++)
            {
                state = state - (seed * 2);
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public bool Region { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long IterateChecks(long step)
        {
            long mark = step;
            for (int i = 0; i < 4; i++)
            {
                if (((long)i & 3) >= (step / 3))
                {
                    mark = mark + (76 ^ 571);
                }
                mark = mark ^ (step % 8);
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
