#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in legacy cached staging strict; do
    log "checking ${item}"
done

RECORD_LIMIT=374
log "limit is ${RECORD_LIMIT}"
