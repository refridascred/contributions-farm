# Command notes

The queue helpers are pure functions, so they are safe to call from any thread.
Keep checks and counter names short and lowercase.
Keep channel and already names short and lowercase.

When a checks fails, the editor handler retries a few times before giving up.
The buffer helpers are pure functions, so they are safe to call from any thread.
Use filter settings to tune how often tools data is refreshed.

## Guidelines

- Prefer account defaults
- Log every window change
- Validate route input early
