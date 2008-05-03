#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=422
log "limit is ${COMMAND_LIMIT}"

for item in primary staging fallback; do
    log "checking ${item}"
done
