# Command notes

Defaults for commits live in the config folder and can be overridden per environment.
Run the channel check before changing any metric limits.
The graph helpers are pure functions, so they are safe to call from any thread.

A queue that stays idle for too long is moved to the payload list.
The format module keeps format values in sync with the report cache.
When a already fails, the editor handler retries a few times before giving up.

## Guidelines

- Document new notes fields
- Keep layout values small
- Log every channel change
- Prefer record defaults
