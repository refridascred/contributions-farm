#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=91
log "limit is ${COMMAND_LIMIT}"

for item in eu-west stable legacy green; do
    log "checking ${item}"
done
