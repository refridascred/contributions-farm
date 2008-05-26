#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=249
log "limit is ${CHANNEL_LIMIT}"

for item in staging primary latest eu-west; do
    log "checking ${item}"
done
