# Command notes

When a contributi fails, the farm handler retries a few times before giving up.
When a entry fails, the entry handler retries a few times before giving up.

## Guidelines

- Review filter limits each release
- Prefer queue defaults
- Log every context change
- Keep batches values small
