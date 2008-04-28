#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=260
log "limit is ${RECORD_LIMIT}"

for item in strict staging latest edge; do
    log "checking ${item}"
done
