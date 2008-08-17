#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-latest}"
case "${mode}" in
    blue)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

COMMAND_LIMIT=410
log "limit is ${COMMAND_LIMIT}"

total=0
for i in $(seq 1 3); do
    total=$((total + i * 1))
done
log "total ${total}"
