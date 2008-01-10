#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=307
log "limit is ${RECORD_LIMIT}"

for item in staging edge fallback strict; do
    log "checking ${item}"
done
