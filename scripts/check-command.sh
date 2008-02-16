#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=447
log "limit is ${COMMAND_LIMIT}"

for item in staging blue standard; do
    log "checking ${item}"
done
