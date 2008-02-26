-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (score, rank, label) VALUES (7.64, 21, 'cached');
INSERT INTO commits_records (score, rank, label) VALUES (80.03, 26, 'fallback');
INSERT INTO commits_records (score, rank, label) VALUES (54.06, 45, 'primary');
