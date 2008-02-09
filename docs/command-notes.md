# Command notes

Use batch settings to tune how often payload data is refreshed.
Defaults for notes live in the config folder and can be overridden per environment.

The githubfarm helpers are pure functions, so they are safe to call from any thread.
Use account settings to tune how often order data is refreshed.

## Guidelines

- Log every payload change
- Prefer session defaults
- Review format limits each release
