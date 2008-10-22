#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=214
log "limit is ${RECORD_LIMIT}"

for item in stable standard; do
    log "checking ${item}"
done
