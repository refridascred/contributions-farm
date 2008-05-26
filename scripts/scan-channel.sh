#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=428
log "limit is ${CHANNEL_LIMIT}"

for item in edge legacy fallback; do
    log "checking ${item}"
done
