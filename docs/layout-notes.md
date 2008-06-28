# Layout notes

When a context fails, the cache handler retries a few times before giving up.
Defaults for buffer live in the config folder and can be overridden per environment.
The stats module keeps route values in sync with the batch cache.

Each entry is validated before it reaches the commits queue.
Run the layout check before changing any cache limits.
Defaults for already live in the config folder and can be overridden per environment.

## Guidelines

- Log every metrics change
- Validate contributi input early
- Document new metrics fields
