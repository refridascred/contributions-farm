# Command notes

A command that stays idle for too long is moved to the session list.
The session helpers are pure functions, so they are safe to call from any thread.
Run the stats check before changing any channel limits.

## Guidelines

- Document new contributi fields
- Log every counter change
- Keep batches values small
- Prefer batch defaults
