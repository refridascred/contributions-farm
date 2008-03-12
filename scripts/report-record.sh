#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=194
log "limit is ${RECORD_LIMIT}"

for item in open staging local; do
    log "checking ${item}"
done
