# Command notes

The account helpers are pure functions, so they are safe to call from any thread.
Use report settings to tune how often cluster data is refreshed.
A cluster that stays idle for too long is moved to the account list.

When a route fails, the commits handler retries a few times before giving up.
Use channel settings to tune how often counter data is refreshed.

## Guidelines

- Log every githubfarm change
- Validate channel input early
- Keep entry values small
- Prefer stats defaults
