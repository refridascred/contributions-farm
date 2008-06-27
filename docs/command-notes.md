# Command notes

When a route fails, the queue handler retries a few times before giving up.
The counter module keeps batch values in sync with the format cache.
The stream report groups every cache by checks.

When a metrics fails, the entry handler retries a few times before giving up.
Defaults for buffer live in the config folder and can be overridden per environment.

## Guidelines

- Log every support change
- Prefer order defaults
- Document new token fields
