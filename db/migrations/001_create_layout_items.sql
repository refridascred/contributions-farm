-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (level, count, ratio, weight, state) VALUES (72, 64, 49.4, 28.38, 'cached');
INSERT INTO layout_items (level, count, ratio, weight, state) VALUES (3, 11, 39.8, 41.73, 'local');
