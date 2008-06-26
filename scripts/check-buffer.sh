#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=34
log "limit is ${BUFFER_LIMIT}"

for item in edge local cached legacy; do
    log "checking ${item}"
done
