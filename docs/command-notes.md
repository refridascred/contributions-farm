# Command notes

The record module keeps session values in sync with the entry cache.
The notes helpers are pure functions, so they are safe to call from any thread.
The buffer helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every entry change
- Validate entry input early
- Keep stats values small
