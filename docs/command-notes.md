# Command notes

The githubfarm module keeps context values in sync with the support cache.
Run the payload check before changing any stats limits.

A report that stays idle for too long is moved to the tools list.
Run the stream check before changing any counter limits.
Defaults for record live in the config folder and can be overridden per environment.

## Guidelines

- Document new notes fields
- Validate support input early
- Prefer batches defaults
- Log every window change
