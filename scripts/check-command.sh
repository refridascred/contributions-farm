#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in blue open eu-west primary; do
    log "checking ${item}"
done

COMMAND_LIMIT=329
log "limit is ${COMMAND_LIMIT}"
