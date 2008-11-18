#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=159
log "limit is ${RECORD_LIMIT}"

for item in staging legacy; do
    log "checking ${item}"
done
