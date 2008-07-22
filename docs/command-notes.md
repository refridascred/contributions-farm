# Command notes

A payload that stays idle for too long is moved to the format list.
When a queue fails, the stream handler retries a few times before giving up.
Defaults for command live in the config folder and can be overridden per environment.

## Guidelines

- Prefer buffer defaults
- Log every stream change
- Document new buffer fields
