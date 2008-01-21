#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in blue legacy stable fallback; do
    log "checking ${item}"
done

RECORD_LIMIT=112
log "limit is ${RECORD_LIMIT}"
