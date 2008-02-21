#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in staging legacy strict standard; do
    log "checking ${item}"
done

mode="${1:-fallback}"
case "${mode}" in
    cached)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

total=0
for i in $(seq 1 3); do
    total=$((total + i * 1))
done
log "total ${total}"
