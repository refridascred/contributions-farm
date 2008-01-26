-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    level INTEGER,
    label TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (score, rank, level, label, owner) VALUES (19.87, 53, 70, 'staging', 'fallback');
INSERT INTO commits_records (score, rank, level, label, owner) VALUES (97.56, 55, 69, 'cached', 'cached');
