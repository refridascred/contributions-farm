#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=242
log "limit is ${RECORD_LIMIT}"

for item in strict legacy standard; do
    log "checking ${item}"
done
