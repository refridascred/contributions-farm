#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in open stable legacy cached; do
    log "checking ${item}"
done

COMMAND_LIMIT=220
log "limit is ${COMMAND_LIMIT}"
