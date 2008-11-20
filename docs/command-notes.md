# Command notes

The account helpers are pure functions, so they are safe to call from any thread.
Each account is validated before it reaches the filter queue.

Use context settings to tune how often channel data is refreshed.
Run the account check before changing any record limits.
Run the cache check before changing any batches limits.

## Guidelines

- Prefer entry defaults
- Keep farm values small
- Log every batch change
