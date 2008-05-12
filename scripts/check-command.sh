#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in legacy cached staging local; do
    log "checking ${item}"
done

COMMAND_LIMIT=175
log "limit is ${COMMAND_LIMIT}"
