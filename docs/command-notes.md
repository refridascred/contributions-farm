# Command notes

The context report groups every farm by command.
Use order settings to tune how often githubfarm data is refreshed.
The account module keeps command values in sync with the command cache.

When a queue fails, the contributi handler retries a few times before giving up.
The account helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate counter input early
- Review route limits each release
- Document new stats fields
- Log every farm change
