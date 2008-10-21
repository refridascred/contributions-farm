#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in standard open latest local; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 9); do
    total=$((total + i * 5))
done
log "total ${total}"

mode="${1:-strict}"
case "${mode}" in
    standard)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
