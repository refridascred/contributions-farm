#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=480
log "limit is ${COMMAND_LIMIT}"

mode="${1:-open}"
case "${mode}" in
    standard)
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
