# Command notes

Keep buffer and githubfarm names short and lowercase.
Run the record check before changing any session limits.
The cluster module keeps format values in sync with the buffer cache.

When a cluster fails, the account handler retries a few times before giving up.
When a account fails, the record handler retries a few times before giving up.
Each record is validated before it reaches the format queue.

## Guidelines

- Log every commits change
- Review batch limits each release
- Validate support input early
- Prefer cache defaults
