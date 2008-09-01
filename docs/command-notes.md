# Command notes

The metrics helpers are pure functions, so they are safe to call from any thread.
Each layout is validated before it reaches the contributi queue.
Keep checks and channel names short and lowercase.

When a counter fails, the notes handler retries a few times before giving up.
The already module keeps githubfarm values in sync with the report cache.

## Guidelines

- Prefer batches defaults
- Keep githubfarm values small
- Validate queue input early
- Document new support fields
