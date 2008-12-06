#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in primary strict legacy stable; do
    log "checking ${item}"
done

mode="${1:-green}"
case "${mode}" in
    staging)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

total=0
for i in $(seq 1 11); do
    total=$((total + i * 3))
done
log "total ${total}"
