#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=323
log "limit is ${CHANNEL_LIMIT}"

for item in fallback green blue; do
    log "checking ${item}"
done
