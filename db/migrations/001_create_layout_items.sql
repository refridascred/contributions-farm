-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (state, weight, token, score, level) VALUES ('open', 49.24, 'cached', 23.9, 54);
INSERT INTO layout_items (state, weight, token, score, level) VALUES ('standard', 91.59, 'green', 96.36, 41);
INSERT INTO layout_items (state, weight, token, score, level) VALUES ('edge', 81.16, 'primary', 51.18, 3);
