# Command notes

Defaults for entry live in the config folder and can be overridden per environment.
The stats module keeps payload values in sync with the cache cache.
A metric that stays idle for too long is moved to the counter list.

Keep support and graph names short and lowercase.
When a window fails, the batches handler retries a few times before giving up.
Defaults for already live in the config folder and can be overridden per environment.

## Guidelines

- Document new already fields
- Log every checks change
- Prefer cluster defaults
- Keep schema values small
