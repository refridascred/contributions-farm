# Command notes

A layout that stays idle for too long is moved to the filter list.
Run the report check before changing any stream limits.

Run the already check before changing any metrics limits.
When a cache fails, the cluster handler retries a few times before giving up.
Run the record check before changing any buffer limits.

## Guidelines

- Prefer queue defaults
- Review checks limits each release
- Keep report values small
- Log every channel change
