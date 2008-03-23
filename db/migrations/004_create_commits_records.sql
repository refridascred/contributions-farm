-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (label, active, state, level, score) VALUES ('open', 66, 'legacy', 84, 57.96);
INSERT INTO commits_records (label, active, state, level, score) VALUES ('cached', 64, 'legacy', 91, 90.33);
INSERT INTO commits_records (label, active, state, level, score) VALUES ('cached', 0, 'local', 7, 5.43);
