# Command notes

The checks report groups every checks by cluster.
Run the token check before changing any report limits.

The githubfarm report groups every context by stream.
Each entry is validated before it reaches the contributi queue.
Keep contributi and context names short and lowercase.

## Guidelines

- Prefer filter defaults
- Validate buffer input early
- Log every record change
- Review command limits each release
