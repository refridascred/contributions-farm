#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in staging primary stable standard; do
    log "checking ${item}"
done

COMMAND_LIMIT=127
log "limit is ${COMMAND_LIMIT}"
