# Command notes

Defaults for payload live in the config folder and can be overridden per environment.
Each cluster is validated before it reaches the cluster queue.
Run the schema check before changing any entry limits.

Defaults for route live in the config folder and can be overridden per environment.
A command that stays idle for too long is moved to the payload list.

## Guidelines

- Review farm limits each release
- Prefer batches defaults
- Document new commits fields
