# Command notes

The contributi module keeps report values in sync with the stats cache.
When a layout fails, the route handler retries a few times before giving up.
Keep command and notes names short and lowercase.

The queue module keeps githubfarm values in sync with the command cache.
The githubfarm helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer batches defaults
- Log every session change
- Document new githubfarm fields
