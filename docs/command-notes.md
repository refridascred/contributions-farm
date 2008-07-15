# Command notes

Run the order check before changing any batch limits.
The schema helpers are pure functions, so they are safe to call from any thread.
A checks that stays idle for too long is moved to the editor list.

## Guidelines

- Document new graph fields
- Validate context input early
- Keep profile values small
