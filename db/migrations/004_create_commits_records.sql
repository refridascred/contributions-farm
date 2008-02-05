-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    ratio REAL,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (state, ratio, weight, count) VALUES ('fallback', 48.18, 59.96, 40);
INSERT INTO commits_records (state, ratio, weight, count) VALUES ('fallback', 50.54, 84.64, 94);
INSERT INTO commits_records (state, ratio, weight, count) VALUES ('green', 27.7, 21.06, 43);
