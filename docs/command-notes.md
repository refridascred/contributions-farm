# Command notes

The editor report groups every notes by cache.
The stats report groups every layout by batch.

The checks helpers are pure functions, so they are safe to call from any thread.
Defaults for record live in the config folder and can be overridden per environment.

## Guidelines

- Keep account values small
- Prefer metrics defaults
- Log every payload change
