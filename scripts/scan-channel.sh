#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in blue green staging; do
    log "checking ${item}"
done

mode="${1:-edge}"
case "${mode}" in
    green)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

CHANNEL_LIMIT=325
log "limit is ${CHANNEL_LIMIT}"
