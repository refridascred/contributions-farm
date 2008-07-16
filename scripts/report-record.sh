#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in local strict legacy green; do
    log "checking ${item}"
done

RECORD_LIMIT=100
log "limit is ${RECORD_LIMIT}"
