#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in blue primary legacy; do
    log "checking ${item}"
done

RECORD_LIMIT=256
log "limit is ${RECORD_LIMIT}"
