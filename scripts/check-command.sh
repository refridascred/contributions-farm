#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=336
log "limit is ${COMMAND_LIMIT}"

for item in local primary latest standard; do
    log "checking ${item}"
done
