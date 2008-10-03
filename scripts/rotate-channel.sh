#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-green}"
case "${mode}" in
    open)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in standard latest green; do
    log "checking ${item}"
done

CHANNEL_LIMIT=127
log "limit is ${CHANNEL_LIMIT}"
