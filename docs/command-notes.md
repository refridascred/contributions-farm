# Command notes

When a report fails, the account handler retries a few times before giving up.
Each graph is validated before it reaches the metrics queue.

The account helpers are pure functions, so they are safe to call from any thread.
Use contributi settings to tune how often cluster data is refreshed.
The filter module keeps channel values in sync with the command cache.

## Guidelines

- Validate order input early
- Log every schema change
- Keep farm values small
- Document new profile fields
