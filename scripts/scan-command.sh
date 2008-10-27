#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=72
log "limit is ${COMMAND_LIMIT}"

for item in cached primary fallback; do
    log "checking ${item}"
done
