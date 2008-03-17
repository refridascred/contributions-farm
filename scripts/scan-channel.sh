#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=485
log "limit is ${CHANNEL_LIMIT}"

for item in cached open fallback; do
    log "checking ${item}"
done
