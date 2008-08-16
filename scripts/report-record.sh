#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=369
log "limit is ${RECORD_LIMIT}"

for item in fallback eu-west primary; do
    log "checking ${item}"
done
