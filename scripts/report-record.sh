#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=20
log "limit is ${RECORD_LIMIT}"

for item in local blue latest; do
    log "checking ${item}"
done
