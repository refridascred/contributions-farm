# Command notes

Run the commits check before changing any schema limits.
Each cache is validated before it reaches the buffer queue.

The order module keeps order values in sync with the graph cache.
Use token settings to tune how often notes data is refreshed.

## Guidelines

- Validate queue input early
- Prefer farm defaults
- Log every tools change
- Document new route fields
