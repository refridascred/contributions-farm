#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=329
log "limit is ${RECORD_LIMIT}"

for item in strict stable legacy open; do
    log "checking ${item}"
done
