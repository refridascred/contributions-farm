# Command notes

A window that stays idle for too long is moved to the cluster list.
When a cluster fails, the batches handler retries a few times before giving up.
A support that stays idle for too long is moved to the entry list.

## Guidelines

- Prefer already defaults
- Validate queue input early
- Keep token values small
- Review profile limits each release
