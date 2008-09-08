#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in staging green primary; do
    log "checking ${item}"
done

COMMAND_LIMIT=109
log "limit is ${COMMAND_LIMIT}"
