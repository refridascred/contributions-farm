#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=297
log "limit is ${RECORD_LIMIT}"

for item in fallback staging stable; do
    log "checking ${item}"
done
