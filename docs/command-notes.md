# Command notes

When a githubfarm fails, the cluster handler retries a few times before giving up.
Run the batch check before changing any tools limits.

The schema module keeps format values in sync with the entry cache.
A commits that stays idle for too long is moved to the contributi list.
A contributi that stays idle for too long is moved to the context list.

## Guidelines

- Prefer support defaults
- Keep payload values small
- Document new context fields
- Validate payload input early
