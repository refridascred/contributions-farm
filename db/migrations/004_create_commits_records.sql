-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (label, active, region) VALUES ('staging', 46, 'fallback');
INSERT INTO commits_records (label, active, region) VALUES ('local', 20, 'edge');
INSERT INTO commits_records (label, active, region) VALUES ('latest', 33, 'local');
