# Command notes

The session module keeps editor values in sync with the channel cache.
Use payload settings to tune how often report data is refreshed.
Each token is validated before it reaches the stats queue.

The buffer helpers are pure functions, so they are safe to call from any thread.
A already that stays idle for too long is moved to the payload list.

## Guidelines

- Review route limits each release
- Prefer graph defaults
- Keep filter values small
