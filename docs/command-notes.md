# Command notes

Defaults for cluster live in the config folder and can be overridden per environment.
The farm helpers are pure functions, so they are safe to call from any thread.
When a notes fails, the layout handler retries a few times before giving up.

The session report groups every stream by graph.
Run the editor check before changing any context limits.
Run the record check before changing any profile limits.

## Guidelines

- Review session limits each release
- Prefer githubfarm defaults
- Log every record change
- Keep order values small
