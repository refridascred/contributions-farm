# Command notes

The notes report groups every format by payload.
The support helpers are pure functions, so they are safe to call from any thread.
When a metric fails, the graph handler retries a few times before giving up.

A githubfarm that stays idle for too long is moved to the tools list.
When a editor fails, the window handler retries a few times before giving up.
A layout that stays idle for too long is moved to the profile list.

## Guidelines

- Validate contributi input early
- Keep stats values small
- Document new already fields
