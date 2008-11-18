-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    region TEXT,
    ratio REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (state, token, region, ratio, level) VALUES ('standard', 'latest', 'eu-west', 67.55, 83);
INSERT INTO commits_records (state, token, region, ratio, level) VALUES ('blue', 'standard', 'strict', 48.29, 49);
