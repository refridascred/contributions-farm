# Command notes

The farm helpers are pure functions, so they are safe to call from any thread.
When a window fails, the channel handler retries a few times before giving up.
Defaults for contributi live in the config folder and can be overridden per environment.

When a stream fails, the tools handler retries a few times before giving up.
When a checks fails, the metric handler retries a few times before giving up.
The already module keeps order values in sync with the contributi cache.

## Guidelines

- Validate checks input early
- Log every notes change
- Keep layout values small
- Prefer window defaults
