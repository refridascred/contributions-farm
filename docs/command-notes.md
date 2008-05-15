# Command notes

Use commits settings to tune how often record data is refreshed.
Use payload settings to tune how often route data is refreshed.
Use record settings to tune how often buffer data is refreshed.

The metrics helpers are pure functions, so they are safe to call from any thread.
Each queue is validated before it reaches the support queue.

## Guidelines

- Validate counter input early
- Document new batch fields
- Log every format change
- Prefer session defaults
