#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in eu-west local blue standard; do
    log "checking ${item}"
done

COMMAND_LIMIT=283
log "limit is ${COMMAND_LIMIT}"
