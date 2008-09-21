-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (score, label) VALUES (66.76, 'cached');
INSERT INTO commits_records (score, label) VALUES (43.93, 'eu-west');
INSERT INTO commits_records (score, label) VALUES (75.32, 'fallback');
