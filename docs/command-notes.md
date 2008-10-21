# Command notes

Use batch settings to tune how often payload data is refreshed.
A token that stays idle for too long is moved to the stats list.
The window helpers are pure functions, so they are safe to call from any thread.

A route that stays idle for too long is moved to the contributi list.
When a command fails, the route handler retries a few times before giving up.

## Guidelines

- Validate farm input early
- Log every route change
- Keep token values small
- Prefer layout defaults
