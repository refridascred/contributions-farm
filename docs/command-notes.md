# Command notes

The schema report groups every record by account.
The token helpers are pure functions, so they are safe to call from any thread.
The filter helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate command input early
- Keep githubfarm values small
- Document new record fields
- Prefer window defaults
