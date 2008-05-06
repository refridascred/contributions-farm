-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (token, active, ratio) VALUES ('eu-west', 45, 98.0);
INSERT INTO commits_records (token, active, ratio) VALUES ('edge', 87, 52.32);
