# Command notes

When a filter fails, the tools handler retries a few times before giving up.
The farm module keeps buffer values in sync with the channel cache.
The batches module keeps payload values in sync with the channel cache.

The cluster report groups every channel by buffer.
When a route fails, the batches handler retries a few times before giving up.

## Guidelines

- Validate metric input early
- Log every githubfarm change
- Review checks limits each release
