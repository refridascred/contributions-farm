#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=474
log "limit is ${RECORD_LIMIT}"

for item in legacy green latest local; do
    log "checking ${item}"
done
