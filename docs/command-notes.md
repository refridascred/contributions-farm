# Command notes

Keep format and farm names short and lowercase.
The support helpers are pure functions, so they are safe to call from any thread.
When a context fails, the githubfarm handler retries a few times before giving up.

## Guidelines

- Log every order change
- Document new route fields
- Prefer stats defaults
