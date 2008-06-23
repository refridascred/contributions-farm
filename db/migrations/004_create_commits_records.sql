-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    token TEXT,
    level INTEGER,
    created_at TIMESTAMP,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (owner, token, level, label) VALUES ('blue', 'cached', 95, 'primary');
INSERT INTO commits_records (owner, token, level, label) VALUES ('edge', 'fallback', 68, 'green');
INSERT INTO commits_records (owner, token, level, label) VALUES ('staging', 'edge', 29, 'cached');
