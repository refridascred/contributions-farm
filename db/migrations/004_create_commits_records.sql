-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (state, token, score, level, active) VALUES ('strict', 'primary', 5.2, 97, 52);
INSERT INTO commits_records (state, token, score, level, active) VALUES ('staging', 'primary', 16.42, 83, 76);
INSERT INTO commits_records (state, token, score, level, active) VALUES ('staging', 'fallback', 23.93, 97, 15);
