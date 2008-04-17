-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    rank INTEGER,
    ratio REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (state, weight, rank, ratio, level) VALUES ('fallback', 52.4, 13, 15.68, 74);
INSERT INTO commits_records (state, weight, rank, ratio, level) VALUES ('fallback', 84.34, 69, 64.6, 80);
