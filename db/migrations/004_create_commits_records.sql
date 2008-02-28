-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    rank INTEGER,
    level INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (label, rank, level, token) VALUES ('edge', 7, 92, 'strict');
INSERT INTO commits_records (label, rank, level, token) VALUES ('strict', 20, 66, 'standard');
