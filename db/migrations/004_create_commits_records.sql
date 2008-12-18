-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (label, count, owner) VALUES ('local', 26, 'primary');
INSERT INTO commits_records (label, count, owner) VALUES ('eu-west', 20, 'fallback');
INSERT INTO commits_records (label, count, owner) VALUES ('eu-west', 96, 'edge');
