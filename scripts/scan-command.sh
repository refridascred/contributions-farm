#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in fallback open; do
    log "checking ${item}"
done

COMMAND_LIMIT=88
log "limit is ${COMMAND_LIMIT}"
