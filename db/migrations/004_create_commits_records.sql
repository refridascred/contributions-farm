-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (ratio, label, state, score, weight) VALUES (53.88, 'edge', 'latest', 93.83, 95.51);
INSERT INTO commits_records (ratio, label, state, score, weight) VALUES (59.59, 'green', 'primary', 19.56, 45.17);
