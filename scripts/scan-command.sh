#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in staging strict primary; do
    log "checking ${item}"
done

COMMAND_LIMIT=116
log "limit is ${COMMAND_LIMIT}"
