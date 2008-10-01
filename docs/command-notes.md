# Command notes

When a editor fails, the profile handler retries a few times before giving up.
Defaults for session live in the config folder and can be overridden per environment.

The layout report groups every batches by already.
The context module keeps profile values in sync with the batch cache.
Each batch is validated before it reaches the layout queue.

## Guidelines

- Keep filter values small
- Document new token fields
- Review report limits each release
- Validate already input early
