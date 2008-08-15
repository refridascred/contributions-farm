#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-local}"
case "${mode}" in
    staging)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in blue edge green eu-west; do
    log "checking ${item}"
done

CHANNEL_LIMIT=450
log "limit is ${CHANNEL_LIMIT}"
