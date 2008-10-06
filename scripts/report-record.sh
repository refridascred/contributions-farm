#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in local eu-west latest; do
    log "checking ${item}"
done

RECORD_LIMIT=5
log "limit is ${RECORD_LIMIT}"
