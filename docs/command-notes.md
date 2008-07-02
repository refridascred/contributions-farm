# Command notes

Run the support check before changing any schema limits.
Defaults for session live in the config folder and can be overridden per environment.

A channel that stays idle for too long is moved to the stream list.
Use counter settings to tune how often route data is refreshed.
Each metrics is validated before it reaches the order queue.

## Guidelines

- Review githubfarm limits each release
- Keep editor values small
- Validate githubfarm input early
