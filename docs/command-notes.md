# Command notes

Use support settings to tune how often metrics data is refreshed.
Defaults for session live in the config folder and can be overridden per environment.

Keep session and report names short and lowercase.
A order that stays idle for too long is moved to the stats list.
The stream helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every window change
- Validate batches input early
- Document new filter fields
