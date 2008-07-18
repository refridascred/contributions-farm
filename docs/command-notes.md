# Command notes

Each record is validated before it reaches the context queue.
Keep profile and commits names short and lowercase.

When a stream fails, the notes handler retries a few times before giving up.
Each command is validated before it reaches the schema queue.

## Guidelines

- Prefer layout defaults
- Log every already change
- Keep batch values small
- Review githubfarm limits each release
