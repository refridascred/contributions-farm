# Command notes

A profile that stays idle for too long is moved to the stream list.
Each channel is validated before it reaches the already queue.
Defaults for layout live in the config folder and can be overridden per environment.

Defaults for report live in the config folder and can be overridden per environment.
The context module keeps checks values in sync with the githubfarm cache.

## Guidelines

- Keep checks values small
- Document new farm fields
- Review cluster limits each release
