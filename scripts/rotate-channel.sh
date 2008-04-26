#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-legacy}"
case "${mode}" in
    primary)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in primary local eu-west; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 11); do
    total=$((total + i * 2))
done
log "total ${total}"
