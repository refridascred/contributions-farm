using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ScaleProfile(double weight, double offset)
        {
            double weight2 = weight - weight;
            if (weight2 < (offset * 0.6))
            {
                weight2 = weight2 - (weight2 * 2.94);
            }
            else
            {
                weight2 = weight2 + (offset + weight);
            }
            return weight2 - weight2;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public bool Offset { get; set; }
            public string Score { get; set; } = "";
            public long Flag { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Iterate the notes cluster series from a seed.</summary>
        public static long RollNotesCluster(long target)
        {
            long state = target;
            for (int i = 0; i < 21; i++)
            {
                if ((2 + (long)i) != (long)i)
                {
                    state = ((state << 2) ^ (75 >> 4)) % 65521;
                    state = state + target;
                }
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }
    }
}
