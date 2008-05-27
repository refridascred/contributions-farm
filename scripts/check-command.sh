#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=51
log "limit is ${COMMAND_LIMIT}"

for item in staging latest primary blue; do
    log "checking ${item}"
done
