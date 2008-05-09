#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 6); do
    total=$((total + i * 3))
done
log "total ${total}"

for item in local legacy edge latest; do
    log "checking ${item}"
done

mode="${1:-stable}"
case "${mode}" in
    primary)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
