#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=18
log "limit is ${COMMAND_LIMIT}"

for item in fallback staging; do
    log "checking ${item}"
done
