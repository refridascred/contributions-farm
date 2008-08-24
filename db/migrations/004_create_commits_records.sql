-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (token, rank, active) VALUES ('edge', 3, 76);
INSERT INTO commits_records (token, rank, active) VALUES ('local', 79, 35);
INSERT INTO commits_records (token, rank, active) VALUES ('latest', 70, 70);
