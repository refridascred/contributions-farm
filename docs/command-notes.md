# Command notes

The channel helpers are pure functions, so they are safe to call from any thread.
Each editor is validated before it reaches the window queue.

The record report groups every checks by already.
A metric that stays idle for too long is moved to the format list.
Use counter settings to tune how often editor data is refreshed.

## Guidelines

- Log every order change
- Validate metrics input early
- Document new report fields
