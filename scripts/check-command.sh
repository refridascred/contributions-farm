#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=306
log "limit is ${COMMAND_LIMIT}"

for item in local blue green; do
    log "checking ${item}"
done
