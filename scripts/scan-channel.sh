#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=290
log "limit is ${CHANNEL_LIMIT}"

for item in legacy fallback; do
    log "checking ${item}"
done
