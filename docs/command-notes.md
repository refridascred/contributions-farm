# Command notes

Use layout settings to tune how often checks data is refreshed.
Use payload settings to tune how often support data is refreshed.
The cache helpers are pure functions, so they are safe to call from any thread.

A graph that stays idle for too long is moved to the notes list.
Defaults for window live in the config folder and can be overridden per environment.
Use batch settings to tune how often token data is refreshed.

## Guidelines

- Document new batches fields
- Prefer tools defaults
- Log every batch change
- Validate account input early
