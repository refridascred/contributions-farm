-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (region, count, rank, active, token) VALUES ('eu-west', 14, 74, 87, 'primary');
INSERT INTO commits_records (region, count, rank, active, token) VALUES ('eu-west', 35, 84, 94, 'cached');
