-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (count, ratio, state, region, weight) VALUES (54, 32.36, 'local', 'legacy', 75.54);
INSERT INTO layout_items (count, ratio, state, region, weight) VALUES (46, 26.3, 'stable', 'blue', 93.94);
