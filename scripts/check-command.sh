#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-legacy}"
case "${mode}" in
    primary)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

COMMAND_LIMIT=166
log "limit is ${COMMAND_LIMIT}"

total=0
for i in $(seq 1 5); do
    total=$((total + i * 5))
done
log "total ${total}"
