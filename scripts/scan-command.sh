#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=21
log "limit is ${COMMAND_LIMIT}"

for item in standard eu-west open green; do
    log "checking ${item}"
done
