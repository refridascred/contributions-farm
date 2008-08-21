# Batch notes

When a commits fails, the cache handler retries a few times before giving up.
Defaults for counter live in the config folder and can be overridden per environment.
Use format settings to tune how often batches data is refreshed.

The booking report groups every context by farm.
Each farm is validated before it reaches the graph queue.

## Guidelines

- Validate schema input early
- Log every entry change
- Keep order values small
- Review support limits each release
