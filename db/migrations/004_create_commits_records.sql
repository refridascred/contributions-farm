-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (token, score, label) VALUES ('staging', 14.03, 'fallback');
INSERT INTO commits_records (token, score, label) VALUES ('primary', 53.79, 'open');
INSERT INTO commits_records (token, score, label) VALUES ('strict', 42.63, 'local');
