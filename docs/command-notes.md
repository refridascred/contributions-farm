# Command notes

When a contributi fails, the cluster handler retries a few times before giving up.
Run the cluster check before changing any payload limits.
A format that stays idle for too long is moved to the graph list.

A filter that stays idle for too long is moved to the filter list.
The metrics report groups every counter by editor.

## Guidelines

- Keep counter values small
- Validate cluster input early
- Review githubfarm limits each release
- Document new checks fields
