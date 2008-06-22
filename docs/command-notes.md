# Command notes

Run the context check before changing any entry limits.
The farm helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every buffer change
- Document new counter fields
- Review session limits each release
- Validate commits input early
