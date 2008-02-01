#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in standard legacy local; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 4); do
    total=$((total + i * 2))
done
log "total ${total}"

mode="${1:-legacy}"
case "${mode}" in
    cached)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
