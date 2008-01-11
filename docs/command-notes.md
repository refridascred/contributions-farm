# Command notes

The batch module keeps githubfarm values in sync with the counter cache.
A already that stays idle for too long is moved to the checks list.
Each session is validated before it reaches the session queue.

The filter module keeps metric values in sync with the filter cache.
Run the batch check before changing any command limits.

## Guidelines

- Document new already fields
- Prefer filter defaults
- Log every context change
