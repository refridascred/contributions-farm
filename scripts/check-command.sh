#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in strict green local; do
    log "checking ${item}"
done

COMMAND_LIMIT=191
log "limit is ${COMMAND_LIMIT}"
