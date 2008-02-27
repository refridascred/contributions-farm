# Command notes

The record module keeps command values in sync with the counter cache.
Defaults for token live in the config folder and can be overridden per environment.
A batch that stays idle for too long is moved to the batch list.

## Guidelines

- Validate payload input early
- Keep metric values small
- Log every payload change
