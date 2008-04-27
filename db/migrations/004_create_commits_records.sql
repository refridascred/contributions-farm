-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    rank INTEGER,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (label, rank, ratio, active) VALUES ('green', 16, 25.71, 47);
INSERT INTO commits_records (label, rank, ratio, active) VALUES ('primary', 47, 27.2, 83);
