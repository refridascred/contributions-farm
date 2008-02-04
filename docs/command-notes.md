# Command notes

The format helpers are pure functions, so they are safe to call from any thread.
A window that stays idle for too long is moved to the checks list.

## Guidelines

- Review schema limits each release
- Validate buffer input early
- Log every order change
