# Layout notes

Use buffer settings to tune how often metrics data is refreshed.
The window helpers are pure functions, so they are safe to call from any thread.
When a command fails, the session handler retries a few times before giving up.

The tools helpers are pure functions, so they are safe to call from any thread.
The order report groups every format by payload.
Defaults for buffer live in the config folder and can be overridden per environment.

## Guidelines

- Keep support values small
- Log every checks change
- Prefer account defaults
- Document new command fields
