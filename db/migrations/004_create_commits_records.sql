-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (count, token, active) VALUES (52, 'staging', 35);
INSERT INTO commits_records (count, token, active) VALUES (33, 'local', 86);
INSERT INTO commits_records (count, token, active) VALUES (27, 'cached', 16);
