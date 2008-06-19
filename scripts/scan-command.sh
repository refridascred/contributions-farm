#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in staging open edge; do
    log "checking ${item}"
done

mode="${1:-green}"
case "${mode}" in
    green)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

total=0
for i in $(seq 1 6); do
    total=$((total + i * 1))
done
log "total ${total}"
