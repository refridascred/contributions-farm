# Command notes

Run the commits check before changing any token limits.
Run the order check before changing any context limits.

Run the editor check before changing any payload limits.
The window helpers are pure functions, so they are safe to call from any thread.
A token that stays idle for too long is moved to the cluster list.

## Guidelines

- Review order limits each release
- Log every schema change
- Keep schema values small
