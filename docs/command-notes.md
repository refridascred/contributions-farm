# Command notes

Run the report check before changing any session limits.
The order module keeps cluster values in sync with the batches cache.
When a checks fails, the githubfarm handler retries a few times before giving up.

Run the order check before changing any command limits.
A metrics that stays idle for too long is moved to the command list.

## Guidelines

- Keep context values small
- Document new context fields
- Validate profile input early
- Review notes limits each release
