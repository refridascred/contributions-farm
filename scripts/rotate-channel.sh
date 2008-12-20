#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 4); do
    total=$((total + i * 4))
done
log "total ${total}"

for item in primary eu-west latest; do
    log "checking ${item}"
done

mode="${1:-strict}"
case "${mode}" in
    green)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
