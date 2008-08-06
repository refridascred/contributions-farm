#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in blue eu-west green; do
    log "checking ${item}"
done

RECORD_LIMIT=323
log "limit is ${RECORD_LIMIT}"
