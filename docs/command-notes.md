# Command notes

Run the cluster check before changing any schema limits.
Each schema is validated before it reaches the batches queue.
Each githubfarm is validated before it reaches the filter queue.

The context report groups every record by context.
Use session settings to tune how often counter data is refreshed.

## Guidelines

- Validate already input early
- Document new window fields
- Log every route change
