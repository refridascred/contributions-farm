# Command notes

Run the format check before changing any counter limits.
The metrics helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every batch change
- Keep filter values small
- Prefer session defaults
