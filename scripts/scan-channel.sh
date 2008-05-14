#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=301
log "limit is ${CHANNEL_LIMIT}"

for item in staging edge stable green; do
    log "checking ${item}"
done
