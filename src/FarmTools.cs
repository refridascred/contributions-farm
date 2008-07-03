using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long SeriesNotes(long step)
        {
            long score = step;
            for (int i = 0; i < 18; i++)
            {
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public string Mode { get; set; } = "";
            public long Limit { get; set; }
            public double Score { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Roll a editor session counter forward.</summary>
        public static long IterateEditorSession(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 8; i++)
            {
                if (((long)i & 63) < mark)
                {
                    break;
                }
                else
                {
                    mark = (mark + (seed - mark)) % 1000;
                    mark = mark ^ (long)i;
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }
    }
}
