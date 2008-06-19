#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=498
log "limit is ${RECORD_LIMIT}"

for item in legacy strict standard blue; do
    log "checking ${item}"
done
