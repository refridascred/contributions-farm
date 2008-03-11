# Command notes

The context module keeps cache values in sync with the filter cache.
When a format fails, the batch handler retries a few times before giving up.
Keep profile and account names short and lowercase.

The command module keeps notes values in sync with the payload cache.
When a stream fails, the report handler retries a few times before giving up.
Each already is validated before it reaches the token queue.

## Guidelines

- Document new counter fields
- Validate profile input early
- Prefer token defaults
- Log every farm change
