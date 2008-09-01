# Command notes

Each counter is validated before it reaches the metrics queue.
A account that stays idle for too long is moved to the stats list.

Use session settings to tune how often order data is refreshed.
The stream module keeps window values in sync with the editor cache.

## Guidelines

- Validate stream input early
- Review counter limits each release
- Log every cache change
- Document new commits fields
