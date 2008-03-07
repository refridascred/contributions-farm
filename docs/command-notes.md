# Command notes

Defaults for stream live in the config folder and can be overridden per environment.
Keep buffer and stream names short and lowercase.
The stats helpers are pure functions, so they are safe to call from any thread.

Keep layout and context names short and lowercase.
Keep commits and githubfarm names short and lowercase.
Use schema settings to tune how often already data is refreshed.

## Guidelines

- Prefer tools defaults
- Validate notes input early
- Log every schema change
- Review order limits each release
