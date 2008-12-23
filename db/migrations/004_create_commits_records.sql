-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (label, state, region, score, ratio) VALUES ('edge', 'local', 'cached', 98.27, 23.49);
INSERT INTO commits_records (label, state, region, score, ratio) VALUES ('legacy', 'primary', 'legacy', 50.86, 94.94);
