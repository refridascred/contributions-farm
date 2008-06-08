#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=129
log "limit is ${COMMAND_LIMIT}"

for item in eu-west latest primary fallback; do
    log "checking ${item}"
done
