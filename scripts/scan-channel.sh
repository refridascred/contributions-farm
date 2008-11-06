#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in edge green latest primary; do
    log "checking ${item}"
done

CHANNEL_LIMIT=218
log "limit is ${CHANNEL_LIMIT}"
