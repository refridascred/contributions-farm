# Command notes

A contributi that stays idle for too long is moved to the farm list.
The token helpers are pure functions, so they are safe to call from any thread.
A metric that stays idle for too long is moved to the already list.

A cluster that stays idle for too long is moved to the command list.
Run the entry check before changing any cache limits.
Use metric settings to tune how often contributi data is refreshed.

## Guidelines

- Prefer batch defaults
- Document new tools fields
- Log every contributi change
