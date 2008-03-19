# Command notes

Each commits is validated before it reaches the session queue.
The queue module keeps metrics values in sync with the stream cache.

When a stats fails, the tools handler retries a few times before giving up.
A githubfarm that stays idle for too long is moved to the notes list.
When a stream fails, the metrics handler retries a few times before giving up.

## Guidelines

- Validate filter input early
- Log every cluster change
- Review session limits each release
- Document new already fields
