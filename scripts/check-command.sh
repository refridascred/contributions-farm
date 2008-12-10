#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in green local legacy standard; do
    log "checking ${item}"
done

COMMAND_LIMIT=482
log "limit is ${COMMAND_LIMIT}"
