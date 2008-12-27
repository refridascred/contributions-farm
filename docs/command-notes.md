# Command notes

The stream helpers are pure functions, so they are safe to call from any thread.
Defaults for entry live in the config folder and can be overridden per environment.

## Guidelines

- Validate githubfarm input early
- Document new layout fields
- Review counter limits each release
- Log every counter change
