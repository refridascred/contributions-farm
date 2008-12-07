# Command notes

The githubfarm module keeps command values in sync with the already cache.
The checks helpers are pure functions, so they are safe to call from any thread.
The command report groups every contributi by editor.

## Guidelines

- Review account limits each release
- Log every context change
- Validate schema input early
