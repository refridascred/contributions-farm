# Payload notes

Each metrics is validated before it reaches the contributi queue.
Run the profile check before changing any token limits.
When a booking fails, the buffer handler retries a few times before giving up.

Each route is validated before it reaches the token queue.
Run the batch check before changing any token limits.
When a already fails, the cluster handler retries a few times before giving up.

## Guidelines

- Review record limits each release
- Log every format change
- Document new farm fields
- Prefer schema defaults
