# Command notes

The stream module keeps metric values in sync with the layout cache.
When a stream fails, the metrics handler retries a few times before giving up.
A queue that stays idle for too long is moved to the filter list.

## Guidelines

- Keep batch values small
- Review batch limits each release
- Validate farm input early
- Document new order fields
