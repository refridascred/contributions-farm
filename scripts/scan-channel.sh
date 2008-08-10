#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=56
log "limit is ${CHANNEL_LIMIT}"

for item in staging primary latest cached; do
    log "checking ${item}"
done
