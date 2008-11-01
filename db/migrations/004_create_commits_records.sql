-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    token TEXT,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (rank, token, region, active) VALUES (70, 'open', 'green', 25);
INSERT INTO commits_records (rank, token, region, active) VALUES (30, 'local', 'edge', 13);
INSERT INTO commits_records (rank, token, region, active) VALUES (76, 'latest', 'open', 58);
