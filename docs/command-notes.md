# Command notes

The commits report groups every already by cluster.
Run the channel check before changing any tools limits.
A token that stays idle for too long is moved to the profile list.

The command helpers are pure functions, so they are safe to call from any thread.
The queue module keeps editor values in sync with the batches cache.
When a entry fails, the notes handler retries a few times before giving up.

## Guidelines

- Prefer cache defaults
- Review notes limits each release
- Keep counter values small
