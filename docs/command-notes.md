# Command notes

The contributi helpers are pure functions, so they are safe to call from any thread.
Run the counter check before changing any counter limits.

## Guidelines

- Keep batch values small
- Validate cache input early
- Log every cache change
