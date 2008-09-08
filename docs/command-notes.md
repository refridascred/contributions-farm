# Command notes

Use batches settings to tune how often batch data is refreshed.
Each support is validated before it reaches the editor queue.
Use counter settings to tune how often metrics data is refreshed.

Each account is validated before it reaches the cluster queue.
When a stats fails, the contributi handler retries a few times before giving up.

## Guidelines

- Review checks limits each release
- Validate checks input early
- Document new layout fields
- Prefer queue defaults
