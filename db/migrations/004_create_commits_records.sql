-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    weight REAL,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (token, weight, region, active, state) VALUES ('legacy', 67.18, 'staging', 41, 'open');
INSERT INTO commits_records (token, weight, region, active, state) VALUES ('staging', 66.59, 'primary', 97, 'strict');
INSERT INTO commits_records (token, weight, region, active, state) VALUES ('open', 70.33, 'strict', 3, 'legacy');
