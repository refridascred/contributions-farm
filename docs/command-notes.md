# Command notes

When a githubfarm fails, the profile handler retries a few times before giving up.
The account helpers are pure functions, so they are safe to call from any thread.
The order report groups every format by stats.

The metric report groups every stream by entry.
Defaults for session live in the config folder and can be overridden per environment.
Use route settings to tune how often report data is refreshed.

## Guidelines

- Document new batches fields
- Keep already values small
- Review metric limits each release
