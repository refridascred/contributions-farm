#!/usr/bin/env bash
# Check the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=385
log "limit is ${RECORD_LIMIT}"

for item in strict eu-west staging local; do
    log "checking ${item}"
done
