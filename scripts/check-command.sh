#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=69
log "limit is ${COMMAND_LIMIT}"

for item in primary fallback staging open; do
    log "checking ${item}"
done
