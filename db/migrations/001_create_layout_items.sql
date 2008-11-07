-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (region, active, ratio, weight) VALUES ('fallback', 18, 83.29, 79.92);
INSERT INTO layout_items (region, active, ratio, weight) VALUES ('legacy', 55, 23.05, 29.28);
