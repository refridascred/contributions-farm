-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (token, active, count) VALUES ('legacy', 20, 97);
INSERT INTO commits_records (token, active, count) VALUES ('legacy', 71, 54);
INSERT INTO commits_records (token, active, count) VALUES ('legacy', 26, 72);
