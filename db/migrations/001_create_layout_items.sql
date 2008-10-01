-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (state, active, weight, score) VALUES ('fallback', 64, 35.08, 22.14);
INSERT INTO layout_items (state, active, weight, score) VALUES ('green', 67, 1.32, 40.86);
INSERT INTO layout_items (state, active, weight, score) VALUES ('staging', 31, 94.08, 38.79);
