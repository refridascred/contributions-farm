#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in legacy primary edge cached; do
    log "checking ${item}"
done

RECORD_LIMIT=312
log "limit is ${RECORD_LIMIT}"
