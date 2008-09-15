# Command notes

Use window settings to tune how often account data is refreshed.
Use payload settings to tune how often metrics data is refreshed.
The record report groups every batches by command.

The checks helpers are pure functions, so they are safe to call from any thread.
The schema helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate commits input early
- Keep context values small
- Review editor limits each release
