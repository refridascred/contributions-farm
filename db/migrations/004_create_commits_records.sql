-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (score, label) VALUES (55.86, 'cached');
INSERT INTO commits_records (score, label) VALUES (55.01, 'fallback');
INSERT INTO commits_records (score, label) VALUES (68.03, 'standard');
