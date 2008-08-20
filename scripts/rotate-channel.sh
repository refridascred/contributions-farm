#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 6); do
    total=$((total + i * 1))
done
log "total ${total}"

for item in latest standard eu-west; do
    log "checking ${item}"
done

mode="${1:-blue}"
case "${mode}" in
    staging)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
