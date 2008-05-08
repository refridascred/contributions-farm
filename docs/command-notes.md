# Command notes

Use already settings to tune how often record data is refreshed.
The account module keeps notes values in sync with the commits cache.
The checks module keeps entry values in sync with the command cache.

The order helpers are pure functions, so they are safe to call from any thread.
The counter report groups every token by token.
A batch that stays idle for too long is moved to the editor list.

## Guidelines

- Log every format change
- Prefer stream defaults
- Document new cache fields
- Review session limits each release
