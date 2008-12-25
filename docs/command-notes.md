# Command notes

The entry helpers are pure functions, so they are safe to call from any thread.
The command report groups every route by context.

## Guidelines

- Document new entry fields
- Validate metric input early
- Log every command change
- Review profile limits each release
