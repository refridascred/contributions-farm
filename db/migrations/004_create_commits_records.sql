-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    ratio REAL,
    created_at TIMESTAMP,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (label, ratio, token) VALUES ('standard', 6.07, 'cached');
INSERT INTO commits_records (label, ratio, token) VALUES ('fallback', 19.76, 'fallback');
INSERT INTO commits_records (label, ratio, token) VALUES ('legacy', 72.42, 'legacy');
