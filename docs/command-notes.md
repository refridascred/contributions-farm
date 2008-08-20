# Command notes

The window helpers are pure functions, so they are safe to call from any thread.
Use metric settings to tune how often githubfarm data is refreshed.
Use metrics settings to tune how often counter data is refreshed.

Use checks settings to tune how often cache data is refreshed.
The layout report groups every format by window.

## Guidelines

- Keep buffer values small
- Prefer cluster defaults
- Log every queue change
- Validate payload input early
