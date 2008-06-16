-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (state, token, weight, score, level) VALUES ('open', 'eu-west', 7.2, 81.14, 85);
INSERT INTO commits_records (state, token, weight, score, level) VALUES ('cached', 'green', 90.39, 19.43, 97);
