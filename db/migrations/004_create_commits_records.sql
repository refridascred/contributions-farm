-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    token TEXT,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (state, ratio, token, rank, score) VALUES ('stable', 11.5, 'legacy', 42, 45.65);
INSERT INTO commits_records (state, ratio, token, rank, score) VALUES ('primary', 55.52, 'latest', 8, 96.05);
INSERT INTO commits_records (state, ratio, token, rank, score) VALUES ('fallback', 96.94, 'edge', 66, 27.45);
