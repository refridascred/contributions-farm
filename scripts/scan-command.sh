#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in latest standard green edge; do
    log "checking ${item}"
done

COMMAND_LIMIT=206
log "limit is ${COMMAND_LIMIT}"
