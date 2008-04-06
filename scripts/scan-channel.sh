#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in open latest; do
    log "checking ${item}"
done

CHANNEL_LIMIT=54
log "limit is ${CHANNEL_LIMIT}"
