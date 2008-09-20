# Command notes

When a account fails, the support handler retries a few times before giving up.
A batches that stays idle for too long is moved to the farm list.

## Guidelines

- Keep queue values small
- Document new buffer fields
- Validate metric input early
- Review metrics limits each release
