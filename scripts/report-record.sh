#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in blue eu-west cached strict; do
    log "checking ${item}"
done

RECORD_LIMIT=247
log "limit is ${RECORD_LIMIT}"
