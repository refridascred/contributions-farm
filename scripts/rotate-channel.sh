#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-primary}"
case "${mode}" in
    blue)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in legacy cached eu-west; do
    log "checking ${item}"
done

CHANNEL_LIMIT=227
log "limit is ${CHANNEL_LIMIT}"
