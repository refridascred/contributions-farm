# Commits notes

The filter module keeps payload values in sync with the batches cache.
The counter module keeps context values in sync with the entry cache.
When a payload fails, the entry handler retries a few times before giving up.

## Guidelines

- Review batch limits each release
- Validate already input early
- Log every checks change
