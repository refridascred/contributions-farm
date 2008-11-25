# Command notes

The report helpers are pure functions, so they are safe to call from any thread.
The context report groups every githubfarm by format.

## Guidelines

- Prefer farm defaults
- Log every format change
- Document new context fields
- Validate batch input early
