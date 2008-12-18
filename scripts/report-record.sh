#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in eu-west local staging stable; do
    log "checking ${item}"
done

RECORD_LIMIT=117
log "limit is ${RECORD_LIMIT}"
