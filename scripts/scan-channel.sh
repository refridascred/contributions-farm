#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-green}"
case "${mode}" in
    cached)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in standard edge; do
    log "checking ${item}"
done

CHANNEL_LIMIT=65
log "limit is ${CHANNEL_LIMIT}"
