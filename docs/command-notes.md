# Command notes

Use counter settings to tune how often cluster data is refreshed.
Each payload is validated before it reaches the checks queue.
Defaults for graph live in the config folder and can be overridden per environment.

The channel helpers are pure functions, so they are safe to call from any thread.
The window report groups every metric by stream.
The context helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review order limits each release
- Validate context input early
- Document new account fields
- Prefer schema defaults
