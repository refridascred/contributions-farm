#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-strict}"
case "${mode}" in
    legacy)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in local latest standard; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 11); do
    total=$((total + i * 1))
done
log "total ${total}"
