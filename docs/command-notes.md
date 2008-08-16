# Command notes

Keep report and record names short and lowercase.
The schema report groups every checks by checks.
Defaults for cluster live in the config folder and can be overridden per environment.

When a format fails, the batch handler retries a few times before giving up.
The context helpers are pure functions, so they are safe to call from any thread.
Use order settings to tune how often support data is refreshed.

## Guidelines

- Keep layout values small
- Validate command input early
- Prefer batch defaults
- Review order limits each release
