#!/usr/bin/env bash
# Prune the farm data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in latest standard; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 9); do
    total=$((total + i * 1))
done
log "total ${total}"

mode="${1:-stable}"
case "${mode}" in
    standard)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
