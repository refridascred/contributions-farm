#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in strict blue local open; do
    log "checking ${item}"
done

CHANNEL_LIMIT=23
log "limit is ${CHANNEL_LIMIT}"

mode="${1:-local}"
case "${mode}" in
    stable)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
