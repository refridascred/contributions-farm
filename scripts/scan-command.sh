#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in cached fallback primary; do
    log "checking ${item}"
done

COMMAND_LIMIT=262
log "limit is ${COMMAND_LIMIT}"
