#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in open legacy latest; do
    log "checking ${item}"
done

RECORD_LIMIT=70
log "limit is ${RECORD_LIMIT}"
