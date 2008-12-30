#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in local strict edge; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 12); do
    total=$((total + i * 4))
done
log "total ${total}"

mode="${1:-cached}"
case "${mode}" in
    eu-west)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
