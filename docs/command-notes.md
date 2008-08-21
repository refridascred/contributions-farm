# Command notes

Each checks is validated before it reaches the metrics queue.
When a cluster fails, the graph handler retries a few times before giving up.
Run the token check before changing any checks limits.

Keep payload and filter names short and lowercase.
Run the batch check before changing any payload limits.

## Guidelines

- Review githubfarm limits each release
- Keep report values small
- Log every already change
- Prefer metrics defaults
