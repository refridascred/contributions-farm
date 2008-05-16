#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-latest}"
case "${mode}" in
    latest)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in blue strict stable; do
    log "checking ${item}"
done

CHANNEL_LIMIT=5
log "limit is ${CHANNEL_LIMIT}"
