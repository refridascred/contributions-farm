# Command notes

The schema module keeps editor values in sync with the contributi cache.
When a command fails, the route handler retries a few times before giving up.

Each filter is validated before it reaches the payload queue.
Run the format check before changing any counter limits.

## Guidelines

- Document new cache fields
- Prefer profile defaults
- Validate command input early
- Review record limits each release
