# Command notes

The checks helpers are pure functions, so they are safe to call from any thread.
Use window settings to tune how often command data is refreshed.

Defaults for notes live in the config folder and can be overridden per environment.
Each payload is validated before it reaches the context queue.

## Guidelines

- Keep metric values small
- Review route limits each release
- Validate commits input early
- Document new batches fields
