# Command notes

Run the schema check before changing any queue limits.
Use batch settings to tune how often context data is refreshed.

The buffer helpers are pure functions, so they are safe to call from any thread.
The stream report groups every metrics by graph.
Use stream settings to tune how often command data is refreshed.

## Guidelines

- Log every queue change
- Validate entry input early
- Prefer stream defaults
- Review channel limits each release
