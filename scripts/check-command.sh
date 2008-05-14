#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in edge primary local cached; do
    log "checking ${item}"
done

COMMAND_LIMIT=206
log "limit is ${COMMAND_LIMIT}"
