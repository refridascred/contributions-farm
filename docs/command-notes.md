# Command notes

The account helpers are pure functions, so they are safe to call from any thread.
Each contributi is validated before it reaches the window queue.
Keep cluster and context names short and lowercase.

## Guidelines

- Document new githubfarm fields
- Validate metrics input early
- Log every cluster change
- Review already limits each release
