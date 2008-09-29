# Command notes

The support report groups every account by contributi.
The channel module keeps profile values in sync with the stats cache.

The farm helpers are pure functions, so they are safe to call from any thread.
A account that stays idle for too long is moved to the checks list.

## Guidelines

- Review format limits each release
- Log every batch change
- Prefer checks defaults
- Keep farm values small
