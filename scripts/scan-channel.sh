#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in standard stable; do
    log "checking ${item}"
done

CHANNEL_LIMIT=277
log "limit is ${CHANNEL_LIMIT}"

mode="${1:-edge}"
case "${mode}" in
    open)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
