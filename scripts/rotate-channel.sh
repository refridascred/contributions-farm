#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=89
log "limit is ${CHANNEL_LIMIT}"

for item in staging edge green; do
    log "checking ${item}"
done

mode="${1:-cached}"
case "${mode}" in
    staging)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
