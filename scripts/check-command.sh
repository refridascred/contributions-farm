#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=56
log "limit is ${COMMAND_LIMIT}"

mode="${1:-stable}"
case "${mode}" in
    legacy)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

total=0
for i in $(seq 1 4); do
    total=$((total + i * 5))
done
log "total ${total}"
