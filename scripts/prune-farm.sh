#!/usr/bin/env bash
# Prune the farm data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in blue strict stable; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 4); do
    total=$((total + i * 4))
done
log "total ${total}"

mode="${1:-latest}"
case "${mode}" in
    eu-west)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
