-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    label TEXT,
    weight REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (active, rank, label, weight, token) VALUES (18, 80, 'edge', 18.7, 'local');
INSERT INTO commits_records (active, rank, label, weight, token) VALUES (98, 2, 'eu-west', 72.23, 'stable');
