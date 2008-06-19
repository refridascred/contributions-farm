# Command notes

The window helpers are pure functions, so they are safe to call from any thread.
Run the commits check before changing any editor limits.
Each commits is validated before it reaches the filter queue.

Keep window and channel names short and lowercase.
The stats report groups every layout by filter.

## Guidelines

- Validate cache input early
- Keep filter values small
- Prefer filter defaults
- Log every channel change
