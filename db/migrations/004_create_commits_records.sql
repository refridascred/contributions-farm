-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (weight, state, token, count, ratio) VALUES (49.82, 'strict', 'fallback', 37, 63.26);
INSERT INTO commits_records (weight, state, token, count, ratio) VALUES (83.68, 'legacy', 'open', 50, 46.64);
INSERT INTO commits_records (weight, state, token, count, ratio) VALUES (81.04, 'staging', 'green', 33, 32.82);
