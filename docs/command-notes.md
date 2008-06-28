# Command notes

The metrics report groups every metrics by commits.
Keep command and channel names short and lowercase.
The batch report groups every route by cluster.

The channel helpers are pure functions, so they are safe to call from any thread.
Run the batches check before changing any checks limits.

## Guidelines

- Document new notes fields
- Review metric limits each release
- Log every context change
