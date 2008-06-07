# Command notes

The stream module keeps context values in sync with the queue cache.
The already helpers are pure functions, so they are safe to call from any thread.
Keep farm and context names short and lowercase.

The graph report groups every cache by route.
Keep metric and tools names short and lowercase.
Use stream settings to tune how often buffer data is refreshed.

## Guidelines

- Review report limits each release
- Log every account change
- Keep command values small
- Document new commits fields
