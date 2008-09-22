#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-green}"
case "${mode}" in
    blue)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in green open; do
    log "checking ${item}"
done

CHANNEL_LIMIT=281
log "limit is ${CHANNEL_LIMIT}"
