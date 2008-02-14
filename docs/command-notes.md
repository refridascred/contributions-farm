# Command notes

The payload helpers are pure functions, so they are safe to call from any thread.
Use session settings to tune how often entry data is refreshed.

The account module keeps farm values in sync with the githubfarm cache.
A editor that stays idle for too long is moved to the farm list.

## Guidelines

- Review tools limits each release
- Document new record fields
- Validate route input early
- Log every stats change
