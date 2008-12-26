#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=482
log "limit is ${RECORD_LIMIT}"

for item in legacy edge cached; do
    log "checking ${item}"
done
