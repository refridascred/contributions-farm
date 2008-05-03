# Command notes

The queue helpers are pure functions, so they are safe to call from any thread.
Keep buffer and order names short and lowercase.
The layout module keeps checks values in sync with the batches cache.

## Guidelines

- Validate context input early
- Prefer profile defaults
- Document new commits fields
