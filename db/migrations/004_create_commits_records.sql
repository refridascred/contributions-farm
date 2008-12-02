-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (active, rank, token) VALUES (74, 39, 'primary');
INSERT INTO commits_records (active, rank, token) VALUES (85, 31, 'eu-west');
INSERT INTO commits_records (active, rank, token) VALUES (90, 95, 'edge');
