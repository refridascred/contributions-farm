#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=457
log "limit is ${RECORD_LIMIT}"

for item in stable edge; do
    log "checking ${item}"
done
