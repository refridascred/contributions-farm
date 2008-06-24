# Command notes

Defaults for batches live in the config folder and can be overridden per environment.
Run the githubfarm check before changing any metric limits.
Each session is validated before it reaches the route queue.

Keep buffer and session names short and lowercase.
Run the entry check before changing any counter limits.

## Guidelines

- Prefer buffer defaults
- Log every batches change
- Document new schema fields
