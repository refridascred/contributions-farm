# Command notes

Each entry is validated before it reaches the channel queue.
The entry module keeps entry values in sync with the order cache.

A graph that stays idle for too long is moved to the support list.
Run the buffer check before changing any payload limits.

## Guidelines

- Document new window fields
- Keep githubfarm values small
- Log every editor change
