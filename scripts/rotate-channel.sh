#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-staging}"
case "${mode}" in
    eu-west)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in standard legacy strict primary; do
    log "checking ${item}"
done

CHANNEL_LIMIT=421
log "limit is ${CHANNEL_LIMIT}"
