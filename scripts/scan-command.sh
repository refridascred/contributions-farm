#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=124
log "limit is ${COMMAND_LIMIT}"

for item in cached strict edge; do
    log "checking ${item}"
done
