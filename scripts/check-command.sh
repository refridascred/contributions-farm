#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in local strict blue stable; do
    log "checking ${item}"
done

COMMAND_LIMIT=41
log "limit is ${COMMAND_LIMIT}"
