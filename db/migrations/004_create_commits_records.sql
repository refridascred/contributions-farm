-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (count, token, active) VALUES (8, 'blue', 77);
INSERT INTO commits_records (count, token, active) VALUES (17, 'green', 87);
INSERT INTO commits_records (count, token, active) VALUES (32, 'local', 78);
