#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=463
log "limit is ${COMMAND_LIMIT}"

for item in green cached staging legacy; do
    log "checking ${item}"
done
