#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=99
log "limit is ${COMMAND_LIMIT}"

for item in primary fallback open stable; do
    log "checking ${item}"
done
