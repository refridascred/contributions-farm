#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in open blue eu-west; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 6); do
    total=$((total + i * 1))
done
log "total ${total}"

mode="${1:-local}"
case "${mode}" in
    primary)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
