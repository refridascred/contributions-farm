#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=217
log "limit is ${CHANNEL_LIMIT}"

for item in edge latest blue; do
    log "checking ${item}"
done
