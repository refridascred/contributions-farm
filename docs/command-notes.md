# Command notes

When a githubfarm fails, the token handler retries a few times before giving up.
The editor module keeps context values in sync with the metric cache.
When a entry fails, the channel handler retries a few times before giving up.

A cluster that stays idle for too long is moved to the metric list.
Use contributi settings to tune how often cache data is refreshed.

## Guidelines

- Validate layout input early
- Prefer batch defaults
- Keep entry values small
- Document new account fields
