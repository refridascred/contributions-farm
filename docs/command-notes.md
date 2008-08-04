# Command notes

The window module keeps cluster values in sync with the stream cache.
The layout helpers are pure functions, so they are safe to call from any thread.

When a stats fails, the metrics handler retries a few times before giving up.
Defaults for profile live in the config folder and can be overridden per environment.

## Guidelines

- Keep checks values small
- Log every payload change
- Prefer counter defaults
- Review payload limits each release
