# Command notes

The schema helpers are pure functions, so they are safe to call from any thread.
Each command is validated before it reaches the editor queue.

Run the stats check before changing any already limits.
When a metric fails, the editor handler retries a few times before giving up.
The token module keeps account values in sync with the counter cache.

## Guidelines

- Keep contributi values small
- Document new filter fields
- Validate githubfarm input early
- Log every schema change
