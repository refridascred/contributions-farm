-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    weight REAL,
    level INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (active, region, weight, level, owner) VALUES (1, 'legacy', 15.59, 72, 'staging');
INSERT INTO layout_items (active, region, weight, level, owner) VALUES (62, 'green', 17.41, 26, 'edge');
