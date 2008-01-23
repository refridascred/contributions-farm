#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=303
log "limit is ${CHANNEL_LIMIT}"

for item in legacy fallback latest; do
    log "checking ${item}"
done
