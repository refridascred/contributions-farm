#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in edge blue standard; do
    log "checking ${item}"
done

BUFFER_LIMIT=443
log "limit is ${BUFFER_LIMIT}"
