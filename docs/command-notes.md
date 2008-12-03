# Command notes

The account report groups every batch by editor.
The payload module keeps entry values in sync with the cache cache.

Use githubfarm settings to tune how often payload data is refreshed.
The entry report groups every payload by command.
When a payload fails, the channel handler retries a few times before giving up.

## Guidelines

- Keep cache values small
- Validate token input early
- Document new layout fields
- Log every batch change
