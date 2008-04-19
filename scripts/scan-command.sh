#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=500
log "limit is ${COMMAND_LIMIT}"

for item in local strict latest stable; do
    log "checking ${item}"
done
