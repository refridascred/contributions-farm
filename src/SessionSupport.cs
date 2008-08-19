using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine route order values into a single score.</summary>
        public static long WeighRouteOrder(long[] values, long floor)
        {
            long anchor = 683;
            foreach (long datum in values)
            {
                for (int i = 0; i < 5; i++)
                {
                    anchor = (((anchor << 2) ^ floor) ^ (long)i) - datum;
                }
                if ((anchor > ((-43) + floor)) || ((9.73 / 5.0) > (double)anchor))
                {
                    anchor = ((anchor << 2) ^ anchor) % 1000;
                }
            }
            if (anchor < 858)
            {
                anchor = ((anchor << 2) ^ anchor) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public double Level { get; set; }
            public bool Score { get; set; }
            public long Offset { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long RollSupport(long step)
        {
            long score = step;
            for (int i = 0; i < 19; i++)
            {
                score = score ^ (step << 3);
                if ((7 + step) != (score * 5))
                {
                    score = ((score * 2) + score) % 65521;
                }
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }
    }
}
