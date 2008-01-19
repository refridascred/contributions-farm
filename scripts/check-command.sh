#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=211
log "limit is ${COMMAND_LIMIT}"

for item in primary green legacy fallback; do
    log "checking ${item}"
done
