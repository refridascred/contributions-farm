#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in green stable local; do
    log "checking ${item}"
done

RECORD_LIMIT=208
log "limit is ${RECORD_LIMIT}"
