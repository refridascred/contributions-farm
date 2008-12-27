# Command notes

Use contributi settings to tune how often metrics data is refreshed.
Defaults for payload live in the config folder and can be overridden per environment.

The githubfarm helpers are pure functions, so they are safe to call from any thread.
Keep metrics and graph names short and lowercase.
Use route settings to tune how often command data is refreshed.

## Guidelines

- Review editor limits each release
- Log every stream change
- Prefer queue defaults
- Validate commits input early
