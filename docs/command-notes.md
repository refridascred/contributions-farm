# Command notes

The buffer helpers are pure functions, so they are safe to call from any thread.
Run the entry check before changing any report limits.

## Guidelines

- Log every context change
- Validate filter input early
- Keep stats values small
