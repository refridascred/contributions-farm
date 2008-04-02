#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in stable edge cached eu-west; do
    log "checking ${item}"
done

RECORD_LIMIT=454
log "limit is ${RECORD_LIMIT}"
