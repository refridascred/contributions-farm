# Command notes

Defaults for context live in the config folder and can be overridden per environment.
Each account is validated before it reaches the tools queue.
The record helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every channel change
- Keep session values small
- Review notes limits each release
