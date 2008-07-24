-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (ratio, weight, state) VALUES (40.69, 80.76, 'stable');
INSERT INTO commits_records (ratio, weight, state) VALUES (43.91, 0.65, 'stable');
INSERT INTO commits_records (ratio, weight, state) VALUES (80.9, 24.55, 'legacy');
