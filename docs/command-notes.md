# Command notes

When a githubfarm fails, the metrics handler retries a few times before giving up.
Each profile is validated before it reaches the schema queue.
Each layout is validated before it reaches the tools queue.

## Guidelines

- Review already limits each release
- Keep contributi values small
- Validate editor input early
- Prefer commits defaults
