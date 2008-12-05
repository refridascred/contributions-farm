#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in local edge strict standard; do
    log "checking ${item}"
done

COMMAND_LIMIT=402
log "limit is ${COMMAND_LIMIT}"
