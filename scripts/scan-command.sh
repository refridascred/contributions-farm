#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=11
log "limit is ${COMMAND_LIMIT}"

for item in fallback open; do
    log "checking ${item}"
done
