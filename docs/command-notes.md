# Command notes

Use batches settings to tune how often payload data is refreshed.
A buffer that stays idle for too long is moved to the farm list.
The command helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every githubfarm change
- Review stream limits each release
- Validate schema input early
- Document new metric fields
