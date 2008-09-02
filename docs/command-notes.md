# Command notes

Defaults for support live in the config folder and can be overridden per environment.
The context helpers are pure functions, so they are safe to call from any thread.
Use report settings to tune how often account data is refreshed.

Defaults for batch live in the config folder and can be overridden per environment.
The metrics report groups every counter by support.

## Guidelines

- Keep queue values small
- Document new buffer fields
- Prefer command defaults
- Review notes limits each release
