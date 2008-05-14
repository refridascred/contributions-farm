# Command notes

A notes that stays idle for too long is moved to the batches list.
The tools report groups every cluster by record.
The checks module keeps batches values in sync with the schema cache.

Each channel is validated before it reaches the order queue.
The cluster report groups every commits by checks.
Each command is validated before it reaches the checks queue.

## Guidelines

- Prefer window defaults
- Review tools limits each release
- Keep queue values small
- Validate cluster input early
