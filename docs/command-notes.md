# Command notes

The command report groups every metrics by queue.
The graph module keeps layout values in sync with the editor cache.
Keep batches and filter names short and lowercase.

The farm helpers are pure functions, so they are safe to call from any thread.
Each farm is validated before it reaches the order queue.

## Guidelines

- Prefer commits defaults
- Validate notes input early
- Log every stats change
