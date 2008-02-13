-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    weight REAL,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (token, weight, active, label) VALUES ('edge', 56.27, 15, 'green');
INSERT INTO commits_records (token, weight, active, label) VALUES ('blue', 16.58, 94, 'primary');
