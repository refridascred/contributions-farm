#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in fallback stable local strict; do
    log "checking ${item}"
done

COMMAND_LIMIT=131
log "limit is ${COMMAND_LIMIT}"
