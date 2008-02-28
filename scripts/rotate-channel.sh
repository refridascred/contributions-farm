#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in cached staging green local; do
    log "checking ${item}"
done

mode="${1:-fallback}"
case "${mode}" in
    staging)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

CHANNEL_LIMIT=242
log "limit is ${CHANNEL_LIMIT}"
