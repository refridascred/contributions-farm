#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in stable local staging standard; do
    log "checking ${item}"
done

COMMAND_LIMIT=343
log "limit is ${COMMAND_LIMIT}"
