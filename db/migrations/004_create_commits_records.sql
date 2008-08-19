-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (active, token, weight, region) VALUES (23, 'eu-west', 6.99, 'open');
INSERT INTO commits_records (active, token, weight, region) VALUES (53, 'edge', 44.77, 'open');
INSERT INTO commits_records (active, token, weight, region) VALUES (0, 'legacy', 10.53, 'staging');
