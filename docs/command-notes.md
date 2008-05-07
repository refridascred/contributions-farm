# Command notes

Each filter is validated before it reaches the contributi queue.
A cluster that stays idle for too long is moved to the channel list.
The window module keeps contributi values in sync with the route cache.

## Guidelines

- Log every already change
- Keep counter values small
- Prefer channel defaults
- Validate support input early
