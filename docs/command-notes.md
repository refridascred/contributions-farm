# Command notes

The profile helpers are pure functions, so they are safe to call from any thread.
A session that stays idle for too long is moved to the batch list.
Each counter is validated before it reaches the metric queue.

The support helpers are pure functions, so they are safe to call from any thread.
Use layout settings to tune how often report data is refreshed.
The checks report groups every entry by profile.

## Guidelines

- Document new metrics fields
- Log every support change
- Review graph limits each release
