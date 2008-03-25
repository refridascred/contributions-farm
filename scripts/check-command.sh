#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in staging blue standard fallback; do
    log "checking ${item}"
done

COMMAND_LIMIT=359
log "limit is ${COMMAND_LIMIT}"
