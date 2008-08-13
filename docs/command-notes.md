# Command notes

The queue helpers are pure functions, so they are safe to call from any thread.
Use account settings to tune how often metrics data is refreshed.
Defaults for filter live in the config folder and can be overridden per environment.

## Guidelines

- Validate batch input early
- Keep githubfarm values small
- Review graph limits each release
- Prefer command defaults
