# Command notes

Keep cache and notes names short and lowercase.
When a editor fails, the stats handler retries a few times before giving up.

Run the commits check before changing any entry limits.
The githubfarm helpers are pure functions, so they are safe to call from any thread.
The batches module keeps stats values in sync with the batch cache.

## Guidelines

- Prefer layout defaults
- Log every farm change
- Validate stats input early
