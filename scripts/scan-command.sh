#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in staging green local; do
    log "checking ${item}"
done

mode="${1:-blue}"
case "${mode}" in
    primary)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

total=0
for i in $(seq 1 5); do
    total=$((total + i * 4))
done
log "total ${total}"
