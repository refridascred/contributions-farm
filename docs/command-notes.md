# Command notes

Keep layout and metrics names short and lowercase.
Keep graph and channel names short and lowercase.
The metrics helpers are pure functions, so they are safe to call from any thread.

Use checks settings to tune how often notes data is refreshed.
A account that stays idle for too long is moved to the commits list.
Keep buffer and batch names short and lowercase.

## Guidelines

- Log every stats change
- Validate channel input early
- Prefer checks defaults
