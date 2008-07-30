-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    region TEXT,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (count, region, label, state) VALUES (67, 'fallback', 'primary', 'legacy');
INSERT INTO commits_records (count, region, label, state) VALUES (52, 'eu-west', 'latest', 'strict');
INSERT INTO commits_records (count, region, label, state) VALUES (72, 'local', 'staging', 'cached');
