-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (ratio, owner, state, region, active) VALUES (65.38, 'strict', 'latest', 'local', 15);
INSERT INTO commits_records (ratio, owner, state, region, active) VALUES (72.65, 'open', 'fallback', 'edge', 31);
INSERT INTO commits_records (ratio, owner, state, region, active) VALUES (96.44, 'edge', 'fallback', 'strict', 70);
