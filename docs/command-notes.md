# Command notes

Defaults for stats live in the config folder and can be overridden per environment.
Use account settings to tune how often batches data is refreshed.

The githubfarm report groups every channel by account.
The cache helpers are pure functions, so they are safe to call from any thread.
The metrics helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review buffer limits each release
- Keep buffer values small
- Validate notes input early
