# Command notes

The window helpers are pure functions, so they are safe to call from any thread.
Use batch settings to tune how often window data is refreshed.
Each entry is validated before it reaches the checks queue.

## Guidelines

- Prefer counter defaults
- Validate profile input early
- Document new tools fields
