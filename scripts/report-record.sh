#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=160
log "limit is ${RECORD_LIMIT}"

for item in eu-west stable standard local; do
    log "checking ${item}"
done
