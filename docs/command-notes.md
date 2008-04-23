# Command notes

A metrics that stays idle for too long is moved to the context list.
Run the contributi check before changing any queue limits.

Each context is validated before it reaches the order queue.
Keep command and cache names short and lowercase.
Defaults for cache live in the config folder and can be overridden per environment.

## Guidelines

- Validate batch input early
- Document new commits fields
- Keep batches values small
- Log every command change
