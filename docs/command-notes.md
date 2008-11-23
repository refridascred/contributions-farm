# Command notes

Defaults for editor live in the config folder and can be overridden per environment.
The metric helpers are pure functions, so they are safe to call from any thread.
The githubfarm module keeps filter values in sync with the counter cache.

## Guidelines

- Prefer graph defaults
- Validate route input early
- Log every payload change
- Review format limits each release
