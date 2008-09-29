# Command notes

When a checks fails, the notes handler retries a few times before giving up.
Each token is validated before it reaches the support queue.

Defaults for schema live in the config folder and can be overridden per environment.
Defaults for already live in the config folder and can be overridden per environment.
Each counter is validated before it reaches the cache queue.

## Guidelines

- Log every stream change
- Review command limits each release
- Document new batch fields
