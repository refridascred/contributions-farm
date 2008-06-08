#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=413
log "limit is ${RECORD_LIMIT}"

for item in latest open stable standard; do
    log "checking ${item}"
done
