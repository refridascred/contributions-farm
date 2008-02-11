# Command notes

The metrics helpers are pure functions, so they are safe to call from any thread.
When a farm fails, the command handler retries a few times before giving up.

## Guidelines

- Validate command input early
- Prefer queue defaults
- Log every layout change
- Review profile limits each release
