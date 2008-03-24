#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in legacy open blue latest; do
    log "checking ${item}"
done

RECORD_LIMIT=233
log "limit is ${RECORD_LIMIT}"
