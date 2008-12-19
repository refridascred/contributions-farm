# Command notes

A profile that stays idle for too long is moved to the route list.
Each payload is validated before it reaches the counter queue.
Defaults for notes live in the config folder and can be overridden per environment.

Keep token and commits names short and lowercase.
The counter module keeps record values in sync with the buffer cache.
Each commits is validated before it reaches the counter queue.

## Guidelines

- Document new token fields
- Validate account input early
- Prefer command defaults
