-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (token, count, active) VALUES ('eu-west', 25, 49);
INSERT INTO commits_records (token, count, active) VALUES ('strict', 90, 59);
INSERT INTO commits_records (token, count, active) VALUES ('edge', 31, 66);
