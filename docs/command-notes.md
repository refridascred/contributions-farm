# Command notes

The queue report groups every entry by order.
Use schema settings to tune how often profile data is refreshed.
The schema report groups every checks by checks.

Defaults for batch live in the config folder and can be overridden per environment.
The notes helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new buffer fields
- Prefer tools defaults
- Validate layout input early
- Review format limits each release
