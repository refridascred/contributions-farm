#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=250
log "limit is ${COMMAND_LIMIT}"

for item in latest staging fallback open; do
    log "checking ${item}"
done
