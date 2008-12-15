# Command notes

The filter report groups every githubfarm by schema.
The metric helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate metric input early
- Document new batch fields
- Prefer farm defaults
- Review window limits each release
