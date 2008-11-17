#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in latest strict cached edge; do
    log "checking ${item}"
done

COMMAND_LIMIT=184
log "limit is ${COMMAND_LIMIT}"
