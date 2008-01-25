#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in cached strict primary green; do
    log "checking ${item}"
done

COMMAND_LIMIT=356
log "limit is ${COMMAND_LIMIT}"
