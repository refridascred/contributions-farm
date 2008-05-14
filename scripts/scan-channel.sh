#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-stable}"
case "${mode}" in
    eu-west)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in strict standard; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 6); do
    total=$((total + i * 4))
done
log "total ${total}"
