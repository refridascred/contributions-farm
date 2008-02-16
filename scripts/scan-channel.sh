#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in blue strict fallback; do
    log "checking ${item}"
done

mode="${1:-staging}"
case "${mode}" in
    primary)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
