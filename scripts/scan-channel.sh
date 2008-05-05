#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=365
log "limit is ${CHANNEL_LIMIT}"

for item in strict standard blue cached; do
    log "checking ${item}"
done
