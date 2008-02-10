#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in eu-west open; do
    log "checking ${item}"
done

RECORD_LIMIT=314
log "limit is ${RECORD_LIMIT}"
