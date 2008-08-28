# Command notes

The schema module keeps graph values in sync with the entry cache.
Each metric is validated before it reaches the tools queue.
A metric that stays idle for too long is moved to the counter list.

## Guidelines

- Prefer filter defaults
- Validate session input early
- Keep counter values small
