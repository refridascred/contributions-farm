# Command notes

The commits module keeps contributi values in sync with the contributi cache.
Each session is validated before it reaches the batch queue.

A commits that stays idle for too long is moved to the githubfarm list.
The checks module keeps command values in sync with the githubfarm cache.

## Guidelines

- Log every notes change
- Prefer metrics defaults
- Document new batches fields
