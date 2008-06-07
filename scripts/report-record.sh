#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=59
log "limit is ${RECORD_LIMIT}"

for item in legacy green primary edge; do
    log "checking ${item}"
done
