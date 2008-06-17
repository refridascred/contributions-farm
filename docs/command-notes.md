# Command notes

Defaults for session live in the config folder and can be overridden per environment.
A batch that stays idle for too long is moved to the farm list.
The batch module keeps queue values in sync with the checks cache.

The filter module keeps queue values in sync with the contributi cache.
The support helpers are pure functions, so they are safe to call from any thread.
Each account is validated before it reaches the metric queue.

## Guidelines

- Document new token fields
- Review graph limits each release
- Prefer window defaults
