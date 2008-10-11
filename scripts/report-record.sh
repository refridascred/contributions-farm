#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in staging legacy eu-west edge; do
    log "checking ${item}"
done

RECORD_LIMIT=190
log "limit is ${RECORD_LIMIT}"
