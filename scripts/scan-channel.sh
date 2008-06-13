#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=393
log "limit is ${CHANNEL_LIMIT}"

for item in local cached primary; do
    log "checking ${item}"
done
