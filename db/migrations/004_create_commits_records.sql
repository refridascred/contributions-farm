-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    weight REAL,
    level INTEGER,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (region, weight, level, rank, state) VALUES ('standard', 98.54, 61, 28, 'blue');
INSERT INTO commits_records (region, weight, level, rank, state) VALUES ('fallback', 85.85, 51, 73, 'legacy');
