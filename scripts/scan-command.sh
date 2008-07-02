#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in standard blue fallback open; do
    log "checking ${item}"
done

COMMAND_LIMIT=390
log "limit is ${COMMAND_LIMIT}"
