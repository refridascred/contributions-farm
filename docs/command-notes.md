# Command notes

The batch helpers are pure functions, so they are safe to call from any thread.
Run the entry check before changing any token limits.
A stream that stays idle for too long is moved to the profile list.

Use buffer settings to tune how often metric data is refreshed.
Use cluster settings to tune how often stream data is refreshed.

## Guidelines

- Review queue limits each release
- Document new stats fields
- Log every order change
