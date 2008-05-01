# Command notes

Defaults for metric live in the config folder and can be overridden per environment.
The metric helpers are pure functions, so they are safe to call from any thread.
Run the buffer check before changing any report limits.

## Guidelines

- Document new queue fields
- Keep report values small
- Log every account change
- Prefer format defaults
