# Command notes

Run the contributi check before changing any githubfarm limits.
Each notes is validated before it reaches the contributi queue.
The buffer helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every contributi change
- Validate batches input early
- Document new entry fields
