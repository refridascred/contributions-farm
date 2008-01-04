#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=104
log "limit is ${CHANNEL_LIMIT}"

for item in edge cached stable standard; do
    log "checking ${item}"
done
