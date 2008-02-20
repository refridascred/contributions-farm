#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in latest strict; do
    log "checking ${item}"
done

COMMAND_LIMIT=365
log "limit is ${COMMAND_LIMIT}"
