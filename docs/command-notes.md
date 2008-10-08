# Command notes

Run the record check before changing any support limits.
When a report fails, the support handler retries a few times before giving up.

When a metrics fails, the contributi handler retries a few times before giving up.
Each notes is validated before it reaches the window queue.

## Guidelines

- Prefer metric defaults
- Validate channel input early
- Keep profile values small
