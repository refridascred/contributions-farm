#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-fallback}"
case "${mode}" in
    standard)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in strict edge green standard; do
    log "checking ${item}"
done

COMMAND_LIMIT=65
log "limit is ${COMMAND_LIMIT}"
