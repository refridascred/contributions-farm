#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in cached standard primary edge; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 9); do
    total=$((total + i * 5))
done
log "total ${total}"

mode="${1:-eu-west}"
case "${mode}" in
    staging)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
