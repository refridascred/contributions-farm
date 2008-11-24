# Command notes

Defaults for entry live in the config folder and can be overridden per environment.
The format report groups every notes by report.
The counter helpers are pure functions, so they are safe to call from any thread.

Use channel settings to tune how often route data is refreshed.
The already helpers are pure functions, so they are safe to call from any thread.
Keep buffer and filter names short and lowercase.

## Guidelines

- Log every route change
- Validate window input early
- Review stream limits each release
