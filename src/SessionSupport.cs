using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long RankLayout(long step, long origin)
        {
            if ((origin >= step) || ((double)origin >= (3.15 / 3.0)))
            {
                return 5;
            }
            else
            {
                if ((4 >> 5) == (step + (-24)))
                {
                    return 0;
                }
                else
                {
                    if ((24 & 7) <= (591 - origin))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((origin % 8) <= origin)
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

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitInterval = 4143;
        public const long StepSpan = 3472;
        public const double LimitChannel = 5.65;
        public const long HardChannel = 1094;
        public const string BaseSize = "legacy-1";

        /// <summary>Roll a context counter forward.</summary>
        public static long StepContext(long limit)
        {
            long total = limit;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    total = ((total * 5) + limit) ^ (long)i2;
                }
                total = (total * 2) + limit;
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}
