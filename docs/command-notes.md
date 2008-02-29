# Command notes

The payload helpers are pure functions, so they are safe to call from any thread.
Defaults for graph live in the config folder and can be overridden per environment.
Use cluster settings to tune how often order data is refreshed.

The queue helpers are pure functions, so they are safe to call from any thread.
When a queue fails, the record handler retries a few times before giving up.
The already helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every route change
- Keep support values small
- Document new profile fields
- Review context limits each release
