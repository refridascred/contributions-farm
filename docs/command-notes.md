# Command notes

When a token fails, the layout handler retries a few times before giving up.
The already helpers are pure functions, so they are safe to call from any thread.
The command report groups every route by batch.

Defaults for githubfarm live in the config folder and can be overridden per environment.
Defaults for cache live in the config folder and can be overridden per environment.

## Guidelines

- Document new editor fields
- Review graph limits each release
- Prefer metric defaults
- Log every tools change
