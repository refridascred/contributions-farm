# Command notes

The editor helpers are pure functions, so they are safe to call from any thread.
The buffer helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate channel input early
- Keep filter values small
- Document new token fields
- Log every githubfarm change
