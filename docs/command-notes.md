# Command notes

The channel module keeps checks values in sync with the context cache.
Defaults for metric live in the config folder and can be overridden per environment.

The editor report groups every payload by queue.
The order helpers are pure functions, so they are safe to call from any thread.
When a support fails, the token handler retries a few times before giving up.

## Guidelines

- Document new channel fields
- Keep cluster values small
- Prefer support defaults
