#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=98
log "limit is ${COMMAND_LIMIT}"

for item in primary local fallback; do
    log "checking ${item}"
done
