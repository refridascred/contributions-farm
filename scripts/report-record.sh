#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in blue primary latest; do
    log "checking ${item}"
done

RECORD_LIMIT=350
log "limit is ${RECORD_LIMIT}"
