#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in stable strict; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 8); do
    total=$((total + i * 3))
done
log "total ${total}"

mode="${1:-open}"
case "${mode}" in
    eu-west)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
