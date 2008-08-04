# Command notes

Run the contributi check before changing any token limits.
The buffer report groups every graph by entry.

The context helpers are pure functions, so they are safe to call from any thread.
The counter report groups every filter by context.
The metrics module keeps report values in sync with the notes cache.

## Guidelines

- Validate payload input early
- Review route limits each release
- Log every token change
- Prefer farm defaults
