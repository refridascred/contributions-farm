#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-fallback}"
case "${mode}" in
    open)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in stable fallback; do
    log "checking ${item}"
done

CHANNEL_LIMIT=467
log "limit is ${CHANNEL_LIMIT}"
