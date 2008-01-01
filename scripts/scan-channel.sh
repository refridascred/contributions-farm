#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=254
log "limit is ${CHANNEL_LIMIT}"

for item in green staging edge primary; do
    log "checking ${item}"
done
