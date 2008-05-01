#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=333
log "limit is ${CHANNEL_LIMIT}"

mode="${1:-eu-west}"
case "${mode}" in
    open)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in blue standard eu-west open; do
    log "checking ${item}"
done
