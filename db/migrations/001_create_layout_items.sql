-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (region, ratio, score, state, owner) VALUES ('standard', 36.0, 41.36, 'fallback', 'strict');
INSERT INTO layout_items (region, ratio, score, state, owner) VALUES ('blue', 0.8, 92.44, 'blue', 'stable');
INSERT INTO layout_items (region, ratio, score, state, owner) VALUES ('cached', 17.7, 45.38, 'eu-west', 'blue');
