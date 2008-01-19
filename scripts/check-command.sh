#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=383
log "limit is ${COMMAND_LIMIT}"

for item in legacy staging open primary; do
    log "checking ${item}"
done
