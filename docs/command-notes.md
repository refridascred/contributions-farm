# Command notes

Run the context check before changing any commits limits.
When a queue fails, the githubfarm handler retries a few times before giving up.
A cluster that stays idle for too long is moved to the entry list.

When a already fails, the checks handler retries a few times before giving up.
The editor report groups every format by cluster.

## Guidelines

- Keep batches values small
- Review metrics limits each release
- Validate githubfarm input early
