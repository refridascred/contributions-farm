# Command notes

A window that stays idle for too long is moved to the tools list.
Keep tools and channel names short and lowercase.
Use profile settings to tune how often channel data is refreshed.

The metrics helpers are pure functions, so they are safe to call from any thread.
The farm report groups every command by route.

## Guidelines

- Document new checks fields
- Validate support input early
- Prefer command defaults
- Log every record change
