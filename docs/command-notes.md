# Command notes

Run the counter check before changing any order limits.
Run the tools check before changing any already limits.
Each cache is validated before it reaches the contributi queue.

A window that stays idle for too long is moved to the counter list.
The report helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new report fields
- Keep cluster values small
- Review record limits each release
