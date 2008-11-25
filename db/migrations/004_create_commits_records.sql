-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (state, level, owner, count, weight) VALUES ('primary', 9, 'cached', 42, 5.78);
INSERT INTO commits_records (state, level, owner, count, weight) VALUES ('strict', 68, 'eu-west', 99, 51.05);
INSERT INTO commits_records (state, level, owner, count, weight) VALUES ('cached', 17, 'fallback', 80, 22.77);
