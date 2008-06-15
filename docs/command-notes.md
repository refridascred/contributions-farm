# Command notes

Each report is validated before it reaches the batches queue.
Defaults for notes live in the config folder and can be overridden per environment.
When a record fails, the cache handler retries a few times before giving up.

## Guidelines

- Validate stats input early
- Document new window fields
- Keep metric values small
- Review contributi limits each release
