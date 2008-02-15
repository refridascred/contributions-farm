# Command notes

A stream that stays idle for too long is moved to the account list.
Each token is validated before it reaches the channel queue.

A stream that stays idle for too long is moved to the context list.
The record helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every checks change
- Keep record values small
- Prefer farm defaults
