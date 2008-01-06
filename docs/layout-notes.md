# Layout notes

The filter report groups every account by metric.
The commits report groups every stats by filter.

The githubfarm module keeps buffer values in sync with the queue cache.
Run the cache check before changing any graph limits.
A cache that stays idle for too long is moved to the queue list.

## Guidelines

- Review session limits each release
- Log every command change
- Prefer session defaults
