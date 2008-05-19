-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    rank INTEGER,
    token TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (label, rank, token, level) VALUES ('edge', 31, 'primary', 28);
INSERT INTO commits_records (label, rank, token, level) VALUES ('primary', 82, 'stable', 31);
