#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 4); do
    total=$((total + i * 3))
done
log "total ${total}"

for item in local staging eu-west primary; do
    log "checking ${item}"
done

COMMAND_LIMIT=485
log "limit is ${COMMAND_LIMIT}"
