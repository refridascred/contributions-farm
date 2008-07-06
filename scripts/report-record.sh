#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in standard cached local eu-west; do
    log "checking ${item}"
done

RECORD_LIMIT=33
log "limit is ${RECORD_LIMIT}"
