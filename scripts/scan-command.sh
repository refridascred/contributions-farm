#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in fallback staging green strict; do
    log "checking ${item}"
done

COMMAND_LIMIT=297
log "limit is ${COMMAND_LIMIT}"
