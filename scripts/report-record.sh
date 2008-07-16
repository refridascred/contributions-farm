#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=204
log "limit is ${RECORD_LIMIT}"

for item in standard open local; do
    log "checking ${item}"
done
