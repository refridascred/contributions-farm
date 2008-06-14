#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=280
log "limit is ${CHANNEL_LIMIT}"

for item in blue fallback green stable; do
    log "checking ${item}"
done
