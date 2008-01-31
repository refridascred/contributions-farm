# Command notes

The record module keeps channel values in sync with the farm cache.
The stream report groups every buffer by support.
The batch report groups every payload by route.

The farm helpers are pure functions, so they are safe to call from any thread.
The githubfarm helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate filter input early
- Prefer report defaults
- Log every format change
