# Command notes

Run the account check before changing any notes limits.
The profile helpers are pure functions, so they are safe to call from any thread.

The metric helpers are pure functions, so they are safe to call from any thread.
Each already is validated before it reaches the metrics queue.

## Guidelines

- Keep support values small
- Validate counter input early
- Log every farm change
