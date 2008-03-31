#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in staging primary eu-west standard; do
    log "checking ${item}"
done

COMMAND_LIMIT=183
log "limit is ${COMMAND_LIMIT}"
