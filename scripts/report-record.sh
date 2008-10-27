#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in green stable fallback legacy; do
    log "checking ${item}"
done

RECORD_LIMIT=270
log "limit is ${RECORD_LIMIT}"
