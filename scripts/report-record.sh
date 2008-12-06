#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=123
log "limit is ${RECORD_LIMIT}"

for item in strict staging green; do
    log "checking ${item}"
done
