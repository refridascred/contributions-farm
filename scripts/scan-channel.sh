#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in staging local cached blue; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 9); do
    total=$((total + i * 4))
done
log "total ${total}"

mode="${1:-latest}"
case "${mode}" in
    primary)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
