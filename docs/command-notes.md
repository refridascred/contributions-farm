# Command notes

The checks module keeps entry values in sync with the commits cache.
Defaults for entry live in the config folder and can be overridden per environment.
The layout helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new editor fields
- Prefer payload defaults
- Log every profile change
