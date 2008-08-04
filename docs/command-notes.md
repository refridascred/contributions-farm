# Command notes

The format report groups every record by cluster.
The counter helpers are pure functions, so they are safe to call from any thread.

The metric module keeps cluster values in sync with the support cache.
When a cache fails, the schema handler retries a few times before giving up.
Each counter is validated before it reaches the window queue.

## Guidelines

- Log every context change
- Validate channel input early
- Document new tools fields
