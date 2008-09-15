# Command notes

The buffer module keeps payload values in sync with the window cache.
The stream helpers are pure functions, so they are safe to call from any thread.
Use stream settings to tune how often contributi data is refreshed.

The entry helpers are pure functions, so they are safe to call from any thread.
Use window settings to tune how often route data is refreshed.
Keep report and batch names short and lowercase.

## Guidelines

- Review channel limits each release
- Log every farm change
- Prefer layout defaults
- Validate entry input early
