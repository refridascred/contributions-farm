-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    token TEXT,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (state, region, token, weight, count) VALUES ('green', 'primary', 'green', 54.93, 65);
INSERT INTO commits_records (state, region, token, weight, count) VALUES ('strict', 'primary', 'standard', 45.6, 14);
