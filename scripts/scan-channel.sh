#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 12); do
    total=$((total + i * 3))
done
log "total ${total}"

for item in legacy local; do
    log "checking ${item}"
done

mode="${1:-open}"
case "${mode}" in
    standard)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
