#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in stable green latest fallback; do
    log "checking ${item}"
done

COMMAND_LIMIT=155
log "limit is ${COMMAND_LIMIT}"
