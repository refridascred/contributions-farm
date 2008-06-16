#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in blue edge green strict; do
    log "checking ${item}"
done

COMMAND_LIMIT=100
log "limit is ${COMMAND_LIMIT}"
