#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=442
log "limit is ${RECORD_LIMIT}"

for item in blue primary; do
    log "checking ${item}"
done
