# Command notes

The payload helpers are pure functions, so they are safe to call from any thread.
Run the graph check before changing any session limits.

## Guidelines

- Validate command input early
- Keep batches values small
- Log every order change
- Prefer commits defaults
