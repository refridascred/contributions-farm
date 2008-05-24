#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in latest legacy cached; do
    log "checking ${item}"
done

COMMAND_LIMIT=76
log "limit is ${COMMAND_LIMIT}"
