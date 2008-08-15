# Command notes

The command module keeps channel values in sync with the farm cache.
The buffer report groups every route by stats.

The editor report groups every entry by route.
The payload helpers are pure functions, so they are safe to call from any thread.
The entry helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new report fields
- Keep session values small
- Log every window change
