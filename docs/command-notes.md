# Command notes

A channel that stays idle for too long is moved to the command list.
The already module keeps stats values in sync with the checks cache.

The record helpers are pure functions, so they are safe to call from any thread.
The route report groups every notes by tools.

## Guidelines

- Validate counter input early
- Prefer checks defaults
- Keep record values small
- Log every counter change
