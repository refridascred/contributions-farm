-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (token, label, active, count) VALUES ('latest', 'green', 78, 75);
INSERT INTO commits_records (token, label, active, count) VALUES ('local', 'cached', 22, 50);
INSERT INTO commits_records (token, label, active, count) VALUES ('open', 'stable', 13, 33);
