-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (label, owner, state, weight) VALUES ('edge', 'fallback', 'open', 86.16);
INSERT INTO commits_records (label, owner, state, weight) VALUES ('primary', 'green', 'latest', 69.04);
