-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (state, score, ratio) VALUES ('staging', 81.96, 60.36);
INSERT INTO commits_records (state, score, ratio) VALUES ('blue', 87.3, 32.68);
INSERT INTO commits_records (state, score, ratio) VALUES ('blue', 92.7, 64.23);
