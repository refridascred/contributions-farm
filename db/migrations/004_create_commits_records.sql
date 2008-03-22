-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    label TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (active, ratio, label, rank) VALUES (86, 5.01, 'cached', 16);
INSERT INTO commits_records (active, ratio, label, rank) VALUES (88, 51.32, 'latest', 59);
