#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in primary open legacy; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 12); do
    total=$((total + i * 3))
done
log "total ${total}"

mode="${1:-fallback}"
case "${mode}" in
    primary)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
