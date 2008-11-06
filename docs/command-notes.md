# Command notes

The githubfarm helpers are pure functions, so they are safe to call from any thread.
The entry module keeps command values in sync with the entry cache.

The payload module keeps stream values in sync with the batch cache.
The metric module keeps window values in sync with the account cache.

## Guidelines

- Review commits limits each release
- Document new command fields
- Keep stats values small
