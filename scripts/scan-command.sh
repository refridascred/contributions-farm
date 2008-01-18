#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in strict fallback; do
    log "checking ${item}"
done

COMMAND_LIMIT=286
log "limit is ${COMMAND_LIMIT}"
