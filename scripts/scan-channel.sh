#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=154
log "limit is ${CHANNEL_LIMIT}"

for item in green blue primary; do
    log "checking ${item}"
done
