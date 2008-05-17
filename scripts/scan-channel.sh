#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=457
log "limit is ${CHANNEL_LIMIT}"

for item in edge blue; do
    log "checking ${item}"
done
