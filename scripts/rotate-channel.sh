#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in staging edge open; do
    log "checking ${item}"
done

mode="${1:-green}"
case "${mode}" in
    primary)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

CHANNEL_LIMIT=339
log "limit is ${CHANNEL_LIMIT}"
