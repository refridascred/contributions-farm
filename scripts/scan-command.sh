#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in latest primary; do
    log "checking ${item}"
done

COMMAND_LIMIT=310
log "limit is ${COMMAND_LIMIT}"
