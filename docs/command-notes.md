# Command notes

A account that stays idle for too long is moved to the buffer list.
The cache helpers are pure functions, so they are safe to call from any thread.

Run the counter check before changing any command limits.
A cluster that stays idle for too long is moved to the tools list.

## Guidelines

- Keep filter values small
- Document new already fields
- Validate channel input early
