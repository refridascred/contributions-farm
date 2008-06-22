# Command notes

Use channel settings to tune how often payload data is refreshed.
Defaults for support live in the config folder and can be overridden per environment.
The stats report groups every token by counter.

The layout helpers are pure functions, so they are safe to call from any thread.
The githubfarm helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer channel defaults
- Keep notes values small
- Review support limits each release
- Log every batch change
