#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=383
log "limit is ${RECORD_LIMIT}"

for item in blue open; do
    log "checking ${item}"
done
