# Payload notes

The buffer module keeps channel values in sync with the stream cache.
When a context fails, the githubfarm handler retries a few times before giving up.
When a context fails, the payload handler retries a few times before giving up.

Keep session and command names short and lowercase.
Run the booking check before changing any stats limits.
When a session fails, the metric handler retries a few times before giving up.

## Guidelines

- Keep cache values small
- Log every context change
- Document new payload fields
