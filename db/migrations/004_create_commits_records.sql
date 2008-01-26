-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (score, ratio, token, weight) VALUES (46.21, 20.06, 'staging', 13.83);
INSERT INTO commits_records (score, ratio, token, weight) VALUES (41.17, 18.06, 'open', 53.92);
INSERT INTO commits_records (score, ratio, token, weight) VALUES (45.92, 44.68, 'legacy', 16.62);
