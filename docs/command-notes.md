# Command notes

The stats helpers are pure functions, so they are safe to call from any thread.
The checks helpers are pure functions, so they are safe to call from any thread.

A session that stays idle for too long is moved to the githubfarm list.
Use checks settings to tune how often commits data is refreshed.
Keep stats and order names short and lowercase.

## Guidelines

- Keep route values small
- Log every checks change
- Validate editor input early
