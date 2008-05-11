# Command notes

Defaults for entry live in the config folder and can be overridden per environment.
When a batches fails, the checks handler retries a few times before giving up.
Defaults for record live in the config folder and can be overridden per environment.

A cluster that stays idle for too long is moved to the tools list.
Each commits is validated before it reaches the stats queue.
Keep token and buffer names short and lowercase.

## Guidelines

- Validate account input early
- Review graph limits each release
- Document new githubfarm fields
