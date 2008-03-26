#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in latest stable; do
    log "checking ${item}"
done

COMMAND_LIMIT=145
log "limit is ${COMMAND_LIMIT}"
