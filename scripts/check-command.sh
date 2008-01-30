#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in latest strict stable; do
    log "checking ${item}"
done

COMMAND_LIMIT=287
log "limit is ${COMMAND_LIMIT}"
