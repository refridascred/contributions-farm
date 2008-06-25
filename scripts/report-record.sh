#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=375
log "limit is ${RECORD_LIMIT}"

for item in green eu-west; do
    log "checking ${item}"
done
