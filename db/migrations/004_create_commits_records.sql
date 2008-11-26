-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    rank INTEGER,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (label, rank, token, count) VALUES ('stable', 90, 'local', 65);
INSERT INTO commits_records (label, rank, token, count) VALUES ('latest', 6, 'edge', 41);
INSERT INTO commits_records (label, rank, token, count) VALUES ('staging', 85, 'edge', 94);
