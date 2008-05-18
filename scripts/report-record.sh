#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=348
log "limit is ${RECORD_LIMIT}"

for item in cached local latest strict; do
    log "checking ${item}"
done
