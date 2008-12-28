#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=274
log "limit is ${COMMAND_LIMIT}"

for item in fallback stable eu-west primary; do
    log "checking ${item}"
done
