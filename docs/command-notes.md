# Command notes

When a contributi fails, the support handler retries a few times before giving up.
The graph report groups every batches by window.
The metrics helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer counter defaults
- Document new profile fields
- Log every contributi change
