#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=301
log "limit is ${COMMAND_LIMIT}"

for item in blue legacy local cached; do
    log "checking ${item}"
done
