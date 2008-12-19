-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (weight, score, state, level, token) VALUES (28.83, 66.25, 'open', 96, 'legacy');
INSERT INTO layout_items (weight, score, state, level, token) VALUES (66.86, 37.08, 'stable', 14, 'open');
