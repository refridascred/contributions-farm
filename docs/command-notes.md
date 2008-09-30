# Command notes

Keep editor and session names short and lowercase.
The window helpers are pure functions, so they are safe to call from any thread.
Each checks is validated before it reaches the channel queue.

## Guidelines

- Review token limits each release
- Log every cache change
- Keep commits values small
