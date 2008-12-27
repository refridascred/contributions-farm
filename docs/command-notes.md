# Command notes

A checks that stays idle for too long is moved to the record list.
Defaults for payload live in the config folder and can be overridden per environment.
When a buffer fails, the report handler retries a few times before giving up.

A schema that stays idle for too long is moved to the order list.
Keep graph and graph names short and lowercase.
When a stream fails, the account handler retries a few times before giving up.

## Guidelines

- Document new channel fields
- Log every context change
- Prefer notes defaults
