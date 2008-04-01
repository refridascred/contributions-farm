# Command notes

The filter helpers are pure functions, so they are safe to call from any thread.
Use cluster settings to tune how often window data is refreshed.
Keep metrics and token names short and lowercase.

## Guidelines

- Document new commits fields
- Validate window input early
- Review session limits each release
- Log every order change
