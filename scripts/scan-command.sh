#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in strict local fallback eu-west; do
    log "checking ${item}"
done

COMMAND_LIMIT=491
log "limit is ${COMMAND_LIMIT}"
