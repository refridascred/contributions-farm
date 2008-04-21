-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (owner, token, score, rank, label) VALUES ('edge', 'primary', 23.31, 31, 'blue');
INSERT INTO commits_records (owner, token, score, rank, label) VALUES ('edge', 'open', 6.61, 83, 'fallback');
