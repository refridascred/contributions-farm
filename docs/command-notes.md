# Command notes

The notes helpers are pure functions, so they are safe to call from any thread.
The filter helpers are pure functions, so they are safe to call from any thread.
The layout module keeps contributi values in sync with the stream cache.

Use stream settings to tune how often record data is refreshed.
A buffer that stays idle for too long is moved to the window list.

## Guidelines

- Log every tools change
- Validate channel input early
- Keep schema values small
