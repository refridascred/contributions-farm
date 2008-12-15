# Command notes

A record that stays idle for too long is moved to the payload list.
The profile module keeps batch values in sync with the session cache.

The farm module keeps commits values in sync with the githubfarm cache.
The token report groups every session by tools.

## Guidelines

- Prefer session defaults
- Keep report values small
- Review entry limits each release
