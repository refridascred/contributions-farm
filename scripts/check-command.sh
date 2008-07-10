#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=38
log "limit is ${COMMAND_LIMIT}"

for item in green standard fallback; do
    log "checking ${item}"
done
