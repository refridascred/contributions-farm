# Command notes

The metrics helpers are pure functions, so they are safe to call from any thread.
Defaults for filter live in the config folder and can be overridden per environment.

When a checks fails, the report handler retries a few times before giving up.
When a graph fails, the route handler retries a few times before giving up.

## Guidelines

- Review route limits each release
- Log every schema change
- Document new account fields
- Keep cluster values small
