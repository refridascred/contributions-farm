#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=299
log "limit is ${RECORD_LIMIT}"

for item in local staging green strict; do
    log "checking ${item}"
done
