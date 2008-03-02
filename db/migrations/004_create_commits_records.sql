-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    ratio REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (score, token, ratio) VALUES (85.6, 'local', 38.61);
INSERT INTO commits_records (score, token, ratio) VALUES (37.45, 'fallback', 33.52);
INSERT INTO commits_records (score, token, ratio) VALUES (71.39, 'primary', 55.21);
