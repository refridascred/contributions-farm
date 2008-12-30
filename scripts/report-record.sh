#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=67
log "limit is ${RECORD_LIMIT}"

for item in blue green cached local; do
    log "checking ${item}"
done
