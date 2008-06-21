# Command notes

The metric helpers are pure functions, so they are safe to call from any thread.
The payload report groups every farm by stats.
The batch report groups every filter by checks.

## Guidelines

- Log every githubfarm change
- Validate window input early
- Prefer support defaults
- Document new farm fields
