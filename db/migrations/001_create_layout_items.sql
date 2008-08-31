-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (weight, score, token, state, ratio) VALUES (47.05, 73.31, 'green', 'primary', 12.69);
INSERT INTO layout_items (weight, score, token, state, ratio) VALUES (32.16, 69.28, 'legacy', 'green', 55.58);
INSERT INTO layout_items (weight, score, token, state, ratio) VALUES (42.81, 73.55, 'blue', 'edge', 53.28);
