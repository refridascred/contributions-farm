#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in edge legacy; do
    log "checking ${item}"
done

CHANNEL_LIMIT=264
log "limit is ${CHANNEL_LIMIT}"

mode="${1:-primary}"
case "${mode}" in
    green)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
