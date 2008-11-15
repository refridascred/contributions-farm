-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    level INTEGER,
    token TEXT,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (label, level, token, rank, count) VALUES ('staging', 55, 'blue', 12, 63);
INSERT INTO commits_records (label, level, token, rank, count) VALUES ('primary', 59, 'edge', 12, 98);
