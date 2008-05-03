-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    weight REAL,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (region, weight, label, state, count) VALUES ('local', 6.78, 'strict', 'legacy', 50);
INSERT INTO commits_records (region, weight, label, state, count) VALUES ('stable', 71.95, 'local', 'legacy', 65);
INSERT INTO commits_records (region, weight, label, state, count) VALUES ('eu-west', 98.91, 'fallback', 'open', 57);
