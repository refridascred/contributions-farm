# Command notes

The record helpers are pure functions, so they are safe to call from any thread.
Keep entry and batch names short and lowercase.
Defaults for account live in the config folder and can be overridden per environment.

A githubfarm that stays idle for too long is moved to the cluster list.
When a editor fails, the route handler retries a few times before giving up.
Use format settings to tune how often record data is refreshed.

## Guidelines

- Validate profile input early
- Document new report fields
- Prefer payload defaults
- Review tools limits each release
