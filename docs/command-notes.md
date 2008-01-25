# Command notes

The contributi module keeps batches values in sync with the stats cache.
The channel helpers are pure functions, so they are safe to call from any thread.
Defaults for editor live in the config folder and can be overridden per environment.

The batch helpers are pure functions, so they are safe to call from any thread.
Each stream is validated before it reaches the already queue.

## Guidelines

- Prefer route defaults
- Keep cluster values small
- Document new session fields
