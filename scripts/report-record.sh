#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=151
log "limit is ${RECORD_LIMIT}"

for item in fallback strict primary legacy; do
    log "checking ${item}"
done
