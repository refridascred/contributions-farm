#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in primary stable eu-west fallback; do
    log "checking ${item}"
done

COMMAND_LIMIT=172
log "limit is ${COMMAND_LIMIT}"
