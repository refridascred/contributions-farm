# Command notes

A format that stays idle for too long is moved to the payload list.
Each githubfarm is validated before it reaches the order queue.

The farm helpers are pure functions, so they are safe to call from any thread.
Use support settings to tune how often payload data is refreshed.
Use contributi settings to tune how often format data is refreshed.

## Guidelines

- Document new order fields
- Review payload limits each release
- Prefer schema defaults
- Keep schema values small
