# Command notes

Run the tools check before changing any queue limits.
The schema report groups every notes by stats.
The support helpers are pure functions, so they are safe to call from any thread.

A tools that stays idle for too long is moved to the report list.
The metric module keeps contributi values in sync with the channel cache.

## Guidelines

- Review queue limits each release
- Log every account change
- Keep batch values small
