# Command notes

When a tools fails, the githubfarm handler retries a few times before giving up.
Use stats settings to tune how often batches data is refreshed.

A stats that stays idle for too long is moved to the window list.
The graph report groups every stream by context.

## Guidelines

- Log every order change
- Document new format fields
- Validate githubfarm input early
