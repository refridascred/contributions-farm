-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    token TEXT,
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (active, token, label, region) VALUES (8, 'green', 'fallback', 'fallback');
INSERT INTO commits_records (active, token, label, region) VALUES (23, 'fallback', 'legacy', 'eu-west');
INSERT INTO commits_records (active, token, label, region) VALUES (97, 'green', 'fallback', 'eu-west');
