#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-legacy}"
case "${mode}" in
    open)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in cached legacy primary green; do
    log "checking ${item}"
done

CHANNEL_LIMIT=44
log "limit is ${CHANNEL_LIMIT}"
