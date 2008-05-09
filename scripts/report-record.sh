#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in staging eu-west green strict; do
    log "checking ${item}"
done

RECORD_LIMIT=439
log "limit is ${RECORD_LIMIT}"
