# Command notes

The batches module keeps contributi values in sync with the notes cache.
The buffer report groups every checks by record.
The route report groups every token by metric.

The command module keeps counter values in sync with the order cache.
Each context is validated before it reaches the format queue.

## Guidelines

- Validate githubfarm input early
- Log every channel change
- Keep order values small
