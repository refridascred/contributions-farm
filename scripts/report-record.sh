#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in strict blue latest; do
    log "checking ${item}"
done

RECORD_LIMIT=225
log "limit is ${RECORD_LIMIT}"
