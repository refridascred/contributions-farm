-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    rank INTEGER,
    region TEXT,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (owner, rank, region, ratio, state) VALUES ('fallback', 21, 'stable', 37.0, 'green');
INSERT INTO commits_records (owner, rank, region, ratio, state) VALUES ('blue', 76, 'fallback', 42.27, 'open');
INSERT INTO commits_records (owner, rank, region, ratio, state) VALUES ('latest', 86, 'staging', 8.0, 'standard');
