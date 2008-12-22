#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=154
log "limit is ${COMMAND_LIMIT}"

mode="${1:-staging}"
case "${mode}" in
    eu-west)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

total=0
for i in $(seq 1 3); do
    total=$((total + i * 5))
done
log "total ${total}"
