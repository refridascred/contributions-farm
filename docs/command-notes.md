# Command notes

When a cache fails, the checks handler retries a few times before giving up.
Run the profile check before changing any already limits.
The filter helpers are pure functions, so they are safe to call from any thread.

Use order settings to tune how often filter data is refreshed.
Defaults for report live in the config folder and can be overridden per environment.

## Guidelines

- Prefer githubfarm defaults
- Review channel limits each release
- Keep githubfarm values small
