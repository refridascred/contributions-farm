#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-cached}"
case "${mode}" in
    stable)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in standard blue; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 7); do
    total=$((total + i * 2))
done
log "total ${total}"
