# Command notes

The route module keeps already values in sync with the buffer cache.
Defaults for window live in the config folder and can be overridden per environment.
Each schema is validated before it reaches the record queue.

## Guidelines

- Prefer cache defaults
- Validate token input early
- Review route limits each release
- Document new stats fields
