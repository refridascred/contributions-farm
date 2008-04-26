# Command notes

The support module keeps channel values in sync with the batches cache.
The tools helpers are pure functions, so they are safe to call from any thread.
The layout report groups every buffer by stream.

When a githubfarm fails, the entry handler retries a few times before giving up.
The batch report groups every contributi by profile.

## Guidelines

- Validate already input early
- Review batches limits each release
- Document new checks fields
