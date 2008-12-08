# Command notes

Use token settings to tune how often token data is refreshed.
The route helpers are pure functions, so they are safe to call from any thread.
A token that stays idle for too long is moved to the githubfarm list.

## Guidelines

- Document new route fields
- Validate entry input early
- Prefer channel defaults
