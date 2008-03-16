#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=341
log "limit is ${RECORD_LIMIT}"

for item in blue legacy; do
    log "checking ${item}"
done
