-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (owner, ratio, token) VALUES ('stable', 89.76, 'legacy');
INSERT INTO commits_records (owner, ratio, token) VALUES ('stable', 72.87, 'fallback');
INSERT INTO commits_records (owner, ratio, token) VALUES ('cached', 25.84, 'eu-west');
