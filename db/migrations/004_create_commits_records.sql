-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (token, weight, state) VALUES ('fallback', 56.2, 'stable');
INSERT INTO commits_records (token, weight, state) VALUES ('local', 34.24, 'cached');
INSERT INTO commits_records (token, weight, state) VALUES ('strict', 17.81, 'legacy');
