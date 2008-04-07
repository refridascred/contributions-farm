# Command notes

The tools module keeps batch values in sync with the support cache.
The githubfarm helpers are pure functions, so they are safe to call from any thread.
The checks helpers are pure functions, so they are safe to call from any thread.

Use stats settings to tune how often batch data is refreshed.
A editor that stays idle for too long is moved to the route list.

## Guidelines

- Validate token input early
- Document new account fields
- Review layout limits each release
- Log every editor change
