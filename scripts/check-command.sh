#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=229
log "limit is ${COMMAND_LIMIT}"

total=0
for i in $(seq 1 3); do
    total=$((total + i * 5))
done
log "total ${total}"

mode="${1:-local}"
case "${mode}" in
    cached)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
