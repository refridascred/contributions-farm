#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in open strict stable; do
    log "checking ${item}"
done

COMMAND_LIMIT=485
log "limit is ${COMMAND_LIMIT}"
