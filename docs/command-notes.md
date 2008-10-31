# Command notes

Keep metric and editor names short and lowercase.
Keep profile and context names short and lowercase.
The batches report groups every order by metric.

Each record is validated before it reaches the stats queue.
The format helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every format change
- Validate order input early
- Document new filter fields
