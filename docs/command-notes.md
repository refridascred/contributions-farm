# Command notes

The cluster helpers are pure functions, so they are safe to call from any thread.
Use session settings to tune how often token data is refreshed.
The layout module keeps metric values in sync with the context cache.

## Guidelines

- Log every githubfarm change
- Validate stats input early
- Review metric limits each release
- Keep commits values small
