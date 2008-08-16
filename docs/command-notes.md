# Command notes

The batch module keeps context values in sync with the buffer cache.
Keep channel and batches names short and lowercase.
When a window fails, the entry handler retries a few times before giving up.

Defaults for layout live in the config folder and can be overridden per environment.
Run the command check before changing any support limits.

## Guidelines

- Validate filter input early
- Prefer session defaults
- Document new payload fields
