#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=101
log "limit is ${COMMAND_LIMIT}"

for item in open primary legacy staging; do
    log "checking ${item}"
done
