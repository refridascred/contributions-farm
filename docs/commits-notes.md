# Commits notes

A cluster that stays idle for too long is moved to the farm list.
Keep token and metrics names short and lowercase.

When a channel fails, the contributi handler retries a few times before giving up.
Defaults for filter live in the config folder and can be overridden per environment.
Each booking is validated before it reaches the githubfarm queue.

## Guidelines

- Validate token input early
- Keep already values small
- Prefer checks defaults
