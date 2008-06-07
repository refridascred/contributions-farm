-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (ratio, count, label, state, level) VALUES (35.81, 37, 'open', 'strict', 60);
INSERT INTO commits_records (ratio, count, label, state, level) VALUES (56.54, 44, 'local', 'fallback', 10);
INSERT INTO commits_records (ratio, count, label, state, level) VALUES (87.19, 9, 'legacy', 'legacy', 84);
