-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (state, token, score, weight) VALUES ('open', 'latest', 15.78, 65.47);
INSERT INTO layout_items (state, token, score, weight) VALUES ('fallback', 'stable', 50.35, 94.63);
