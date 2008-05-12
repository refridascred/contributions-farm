#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in standard blue local strict; do
    log "checking ${item}"
done

RECORD_LIMIT=160
log "limit is ${RECORD_LIMIT}"
