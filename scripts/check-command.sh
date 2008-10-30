#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in primary legacy fallback; do
    log "checking ${item}"
done

COMMAND_LIMIT=84
log "limit is ${COMMAND_LIMIT}"
