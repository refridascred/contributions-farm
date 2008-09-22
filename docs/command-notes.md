# Command notes

Each commits is validated before it reaches the session queue.
When a stream fails, the token handler retries a few times before giving up.

The notes report groups every stream by session.
Each session is validated before it reaches the profile queue.
A schema that stays idle for too long is moved to the cluster list.

## Guidelines

- Keep account values small
- Log every githubfarm change
- Document new tools fields
