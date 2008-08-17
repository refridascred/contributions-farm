#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in fallback strict staging; do
    log "checking ${item}"
done

COMMAND_LIMIT=407
log "limit is ${COMMAND_LIMIT}"
