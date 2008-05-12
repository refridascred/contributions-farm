#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-cached}"
case "${mode}" in
    open)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in blue eu-west edge; do
    log "checking ${item}"
done

CHANNEL_LIMIT=307
log "limit is ${CHANNEL_LIMIT}"
