# Command notes

Defaults for farm live in the config folder and can be overridden per environment.
Each notes is validated before it reaches the batches queue.

A stream that stays idle for too long is moved to the buffer list.
Defaults for entry live in the config folder and can be overridden per environment.
When a already fails, the report handler retries a few times before giving up.

## Guidelines

- Review notes limits each release
- Keep cluster values small
- Document new commits fields
- Prefer counter defaults
