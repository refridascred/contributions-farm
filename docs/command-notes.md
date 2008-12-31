# Command notes

Run the command check before changing any schema limits.
Keep metrics and queue names short and lowercase.
Each stream is validated before it reaches the batch queue.

The farm report groups every checks by record.
Each commits is validated before it reaches the notes queue.
Each layout is validated before it reaches the notes queue.

## Guidelines

- Review batches limits each release
- Document new command fields
- Keep report values small
