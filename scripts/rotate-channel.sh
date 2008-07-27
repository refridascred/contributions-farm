#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in primary blue legacy staging; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 12); do
    total=$((total + i * 3))
done
log "total ${total}"

mode="${1:-strict}"
case "${mode}" in
    staging)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
