#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in strict legacy local edge; do
    log "checking ${item}"
done

CHANNEL_LIMIT=367
log "limit is ${CHANNEL_LIMIT}"
