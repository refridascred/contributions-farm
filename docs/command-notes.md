# Command notes

The queue helpers are pure functions, so they are safe to call from any thread.
Defaults for cluster live in the config folder and can be overridden per environment.

## Guidelines

- Validate stats input early
- Keep report values small
- Review githubfarm limits each release
- Prefer schema defaults
