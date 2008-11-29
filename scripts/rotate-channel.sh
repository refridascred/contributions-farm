#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in primary green edge staging; do
    log "checking ${item}"
done

mode="${1:-cached}"
case "${mode}" in
    cached)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

CHANNEL_LIMIT=460
log "limit is ${CHANNEL_LIMIT}"
