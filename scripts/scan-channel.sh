#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in primary eu-west legacy; do
    log "checking ${item}"
done

mode="${1:-eu-west}"
case "${mode}" in
    primary)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

total=0
for i in $(seq 1 4); do
    total=$((total + i * 3))
done
log "total ${total}"
