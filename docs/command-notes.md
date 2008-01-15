# Command notes

A payload that stays idle for too long is moved to the channel list.
A cache that stays idle for too long is moved to the order list.

When a account fails, the editor handler retries a few times before giving up.
The stream module keeps profile values in sync with the metric cache.

## Guidelines

- Keep entry values small
- Review filter limits each release
- Document new record fields
