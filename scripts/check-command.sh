#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-fallback}"
case "${mode}" in
    primary)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

COMMAND_LIMIT=233
log "limit is ${COMMAND_LIMIT}"

total=0
for i in $(seq 1 4); do
    total=$((total + i * 3))
done
log "total ${total}"
