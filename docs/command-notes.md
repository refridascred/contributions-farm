# Command notes

The contributi module keeps farm values in sync with the editor cache.
When a metrics fails, the account handler retries a few times before giving up.
Keep tools and cache names short and lowercase.

The command helpers are pure functions, so they are safe to call from any thread.
The payload module keeps command values in sync with the editor cache.
Use token settings to tune how often counter data is refreshed.

## Guidelines

- Review command limits each release
- Log every editor change
- Keep editor values small
