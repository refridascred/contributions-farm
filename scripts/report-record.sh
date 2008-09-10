#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=218
log "limit is ${RECORD_LIMIT}"

for item in open stable local; do
    log "checking ${item}"
done
