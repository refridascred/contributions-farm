#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=168
log "limit is ${RECORD_LIMIT}"

for item in latest legacy open; do
    log "checking ${item}"
done
