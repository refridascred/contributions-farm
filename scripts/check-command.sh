#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=468
log "limit is ${COMMAND_LIMIT}"

for item in local fallback latest open; do
    log "checking ${item}"
done
