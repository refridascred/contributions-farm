# Command notes

Each filter is validated before it reaches the filter queue.
Defaults for channel live in the config folder and can be overridden per environment.
Use graph settings to tune how often session data is refreshed.

Use stream settings to tune how often queue data is refreshed.
The githubfarm helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer layout defaults
- Validate batch input early
- Document new stream fields
- Review stream limits each release
