#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=173
log "limit is ${RECORD_LIMIT}"

for item in eu-west blue edge; do
    log "checking ${item}"
done
