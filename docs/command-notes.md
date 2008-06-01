# Command notes

Each entry is validated before it reaches the order queue.
The cache helpers are pure functions, so they are safe to call from any thread.
Use record settings to tune how often window data is refreshed.

The checks report groups every channel by editor.
Defaults for batch live in the config folder and can be overridden per environment.

## Guidelines

- Keep report values small
- Document new metric fields
- Validate counter input early
- Prefer token defaults
