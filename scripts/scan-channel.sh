#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=198
log "limit is ${CHANNEL_LIMIT}"

for item in blue fallback; do
    log "checking ${item}"
done
