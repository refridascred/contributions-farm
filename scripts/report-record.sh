#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in open green stable standard; do
    log "checking ${item}"
done

RECORD_LIMIT=329
log "limit is ${RECORD_LIMIT}"
