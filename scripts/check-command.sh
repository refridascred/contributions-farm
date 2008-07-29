#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=378
log "limit is ${COMMAND_LIMIT}"

for item in open stable primary; do
    log "checking ${item}"
done
