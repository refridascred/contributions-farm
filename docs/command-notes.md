# Command notes

Run the record check before changing any token limits.
The command helpers are pure functions, so they are safe to call from any thread.
Use already settings to tune how often batch data is refreshed.

## Guidelines

- Review record limits each release
- Validate metrics input early
- Log every account change
