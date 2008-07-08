#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=463
log "limit is ${COMMAND_LIMIT}"

for item in fallback blue; do
    log "checking ${item}"
done
