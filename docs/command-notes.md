# Command notes

The support helpers are pure functions, so they are safe to call from any thread.
Each counter is validated before it reaches the stats queue.

A format that stays idle for too long is moved to the already list.
Run the layout check before changing any format limits.
The command module keeps session values in sync with the profile cache.

## Guidelines

- Prefer contributi defaults
- Keep batch values small
- Log every layout change
- Document new context fields
