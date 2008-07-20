#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=233
log "limit is ${RECORD_LIMIT}"

for item in strict latest local; do
    log "checking ${item}"
done
