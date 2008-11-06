-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    created_at TIMESTAMP,
    token TEXT,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (label, token, ratio, state) VALUES ('strict', 'stable', 75.57, 'legacy');
INSERT INTO commits_records (label, token, ratio, state) VALUES ('standard', 'edge', 19.9, 'legacy');
