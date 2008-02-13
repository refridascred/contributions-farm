#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in strict legacy fallback staging; do
    log "checking ${item}"
done

COMMAND_LIMIT=279
log "limit is ${COMMAND_LIMIT}"
