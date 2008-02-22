-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (count, token, weight) VALUES (0, 'fallback', 17.04);
INSERT INTO commits_records (count, token, weight) VALUES (89, 'cached', 43.91);
INSERT INTO commits_records (count, token, weight) VALUES (98, 'local', 28.39);
