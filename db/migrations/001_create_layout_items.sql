-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (region, state, score, weight, ratio) VALUES ('green', 'blue', 47.95, 80.81, 85.5);
INSERT INTO layout_items (region, state, score, weight, ratio) VALUES ('green', 'green', 87.26, 56.36, 62.35);
INSERT INTO layout_items (region, state, score, weight, ratio) VALUES ('local', 'primary', 86.95, 71.05, 74.79);
