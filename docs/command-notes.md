# Command notes

The metric module keeps token values in sync with the record cache.
A buffer that stays idle for too long is moved to the channel list.
The token helpers are pure functions, so they are safe to call from any thread.

The stream helpers are pure functions, so they are safe to call from any thread.
A cache that stays idle for too long is moved to the entry list.
Keep githubfarm and contributi names short and lowercase.

## Guidelines

- Keep account values small
- Log every report change
- Prefer command defaults
