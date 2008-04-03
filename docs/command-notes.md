# Command notes

When a buffer fails, the batches handler retries a few times before giving up.
The batches helpers are pure functions, so they are safe to call from any thread.
The command report groups every session by schema.

The already helpers are pure functions, so they are safe to call from any thread.
The buffer module keeps batch values in sync with the tools cache.
The support helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review entry limits each release
- Log every farm change
- Keep profile values small
