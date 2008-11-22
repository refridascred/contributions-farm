#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-green}"
case "${mode}" in
    fallback)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in open strict staging blue; do
    log "checking ${item}"
done

CHANNEL_LIMIT=380
log "limit is ${CHANNEL_LIMIT}"
