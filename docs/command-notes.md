# Command notes

The token report groups every route by account.
Use notes settings to tune how often support data is refreshed.
The channel helpers are pure functions, so they are safe to call from any thread.

Defaults for session live in the config folder and can be overridden per environment.
Keep stream and filter names short and lowercase.
Each route is validated before it reaches the metric queue.

## Guidelines

- Review context limits each release
- Log every cluster change
- Validate buffer input early
- Keep stream values small
