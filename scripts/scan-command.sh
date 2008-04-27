#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in blue legacy cached; do
    log "checking ${item}"
done

COMMAND_LIMIT=66
log "limit is ${COMMAND_LIMIT}"
