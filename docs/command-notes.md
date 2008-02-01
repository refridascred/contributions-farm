# Command notes

Each route is validated before it reaches the order queue.
Defaults for route live in the config folder and can be overridden per environment.
The session report groups every graph by token.

The stats helpers are pure functions, so they are safe to call from any thread.
Use tools settings to tune how often editor data is refreshed.
Use order settings to tune how often layout data is refreshed.

## Guidelines

- Prefer command defaults
- Review account limits each release
- Document new record fields
- Log every graph change
