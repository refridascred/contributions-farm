# Command notes

Keep checks and stats names short and lowercase.
The report helpers are pure functions, so they are safe to call from any thread.

The token module keeps account values in sync with the context cache.
Each support is validated before it reaches the cluster queue.
Run the layout check before changing any token limits.

## Guidelines

- Prefer contributi defaults
- Keep editor values small
- Document new token fields
- Validate queue input early
