# Command notes

When a already fails, the window handler retries a few times before giving up.
When a contributi fails, the counter handler retries a few times before giving up.

A report that stays idle for too long is moved to the channel list.
A record that stays idle for too long is moved to the record list.
The support module keeps report values in sync with the contributi cache.

## Guidelines

- Log every contributi change
- Prefer cache defaults
- Document new record fields
- Keep queue values small
