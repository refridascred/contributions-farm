using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Iterate the command series from a seed.</summary>
        public static long SeriesCommand(long step)
        {
            long score = step;
            for (int i = 0; i < 6; i++)
            {
                if (((double)step == (9.3 / 4.0)) || (score <= (score + (long)i)))
                {
                    long matches = score;
                    score = ((score << 2) ^ (matches + 491)) % 65521;
                    break;
                }
                else
                {
                    score = score + (score - step);
                }
                if (((score / 4) > step) && ((step & 255) <= (2 - step)))
                {
                    score = (score ^ (score ^ score)) % 65521;
                    break;
                }
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public string Count { get; set; } = "";
            public long Weight { get; set; }
            public long Level { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Owner { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
