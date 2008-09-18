# Command notes

Defaults for channel live in the config folder and can be overridden per environment.
A contributi that stays idle for too long is moved to the stream list.
Run the format check before changing any commits limits.

Use counter settings to tune how often record data is refreshed.
The tools module keeps record values in sync with the report cache.
The order helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep batches values small
- Prefer batches defaults
- Document new batches fields
- Review layout limits each release
