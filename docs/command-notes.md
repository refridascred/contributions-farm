# Command notes

A session that stays idle for too long is moved to the route list.
Use format settings to tune how often context data is refreshed.
When a support fails, the command handler retries a few times before giving up.

Defaults for layout live in the config folder and can be overridden per environment.
Keep report and window names short and lowercase.
Each filter is validated before it reaches the profile queue.

## Guidelines

- Validate batch input early
- Log every contributi change
- Document new commits fields
- Prefer profile defaults
